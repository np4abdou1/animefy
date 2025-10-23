using System;
using Android.Runtime;

namespace Com.Wang.Avi.Indicators
{
	// Token: 0x0200001D RID: 29
	[Register("com/wang/avi/indicators/LineScalePulseOutIndicator", DoNotGenerateAcw = true)]
	public class LineScalePulseOutIndicator : LineScaleIndicator
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000078D9 File Offset: 0x00005AD9
		internal new static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/indicators/LineScalePulseOutIndicator", ref LineScalePulseOutIndicator.java_class_handle);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000078EA File Offset: 0x00005AEA
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LineScalePulseOutIndicator.class_ref;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000078F1 File Offset: 0x00005AF1
		protected override Type ThresholdType
		{
			get
			{
				return typeof(LineScalePulseOutIndicator);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000078FD File Offset: 0x00005AFD
		protected LineScalePulseOutIndicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007908 File Offset: 0x00005B08
		[Register(".ctor", "()V", "")]
		public LineScalePulseOutIndicator() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(LineScalePulseOutIndicator))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (LineScalePulseOutIndicator.id_ctor == IntPtr.Zero)
			{
				LineScalePulseOutIndicator.id_ctor = JNIEnv.GetMethodID(LineScalePulseOutIndicator.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(LineScalePulseOutIndicator.class_ref, LineScalePulseOutIndicator.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, LineScalePulseOutIndicator.class_ref, LineScalePulseOutIndicator.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x040000C8 RID: 200
		internal new static IntPtr java_class_handle;

		// Token: 0x040000C9 RID: 201
		private static IntPtr id_ctor;
	}
}
