using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001E RID: 30
	[Register("com/wang/avi/indicators/LineScalePulseOutRapidIndicator", DoNotGenerateAcw = true)]
	public class LineScalePulseOutRapidIndicator : LineScaleIndicator
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000079DC File Offset: 0x00005BDC
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/LineScalePulseOutRapidIndicator", ref LineScalePulseOutRapidIndicator.java_class_handle);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000079ED File Offset: 0x00005BED
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LineScalePulseOutRapidIndicator.class_ref;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000079F4 File Offset: 0x00005BF4
		protected override Type ThresholdType
		{
			get
			{
				return typeof(LineScalePulseOutRapidIndicator);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000078FD File Offset: 0x00005AFD
		protected LineScalePulseOutRapidIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007A00 File Offset: 0x00005C00
		[Register(".ctor", "()V", "")]
		public LineScalePulseOutRapidIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(LineScalePulseOutRapidIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (LineScalePulseOutRapidIndicator.id_ctor == IntPtr.Zero)
			{
				LineScalePulseOutRapidIndicator.id_ctor = JNIEnv.GetMethodID(LineScalePulseOutRapidIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(LineScalePulseOutRapidIndicator.class_ref, LineScalePulseOutRapidIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, LineScalePulseOutRapidIndicator.class_ref, LineScalePulseOutRapidIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x040000CA RID: 202
		internal new static IntPtr java_class_handle;

		// Token: 0x040000CB RID: 203
		private static IntPtr id_ctor;
	}
}
