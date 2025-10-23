using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F8 RID: 504
	[Register("android/os/AsyncTask", DoNotGenerateAcw = true)]
	public abstract class AsyncTask<TParams, TProgress, TResult> : AsyncTask
	{
		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000301AF File Offset: 0x0002E3AF
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("android/os/AsyncTask", ref AsyncTask<TParams, TProgress, TResult>.java_class_handle);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000301C0 File Offset: 0x0002E3C0
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AsyncTask<TParams, TProgress, TResult>.class_ref;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000301C7 File Offset: 0x0002E3C7
		protected override Type ThresholdType
		{
			get
			{
				return typeof(AsyncTask);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0002D910 File Offset: 0x0002BB10
		public AsyncTask(IntPtr doNotUse, JniHandleOwnership transfer) : base(doNotUse, transfer)
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000301D4 File Offset: 0x0002E3D4
		public AsyncTask() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			if (base.GetType() != typeof(AsyncTask))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				return;
			}
			if (AsyncTask<TParams, TProgress, TResult>.id_ctor == IntPtr.Zero)
			{
				AsyncTask<TParams, TProgress, TResult>.id_ctor = JNIEnv.GetMethodID(AsyncTask<TParams, TProgress, TResult>.class_ref, "<init>", "()V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(AsyncTask<TParams, TProgress, TResult>.class_ref, AsyncTask<TParams, TProgress, TResult>.id_ctor, Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, AsyncTask<TParams, TProgress, TResult>.class_ref, AsyncTask<TParams, TProgress, TResult>.id_ctor, Array.Empty<JValue>());
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x000302A8 File Offset: 0x0002E4A8
		protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] native_parms)
		{
			TParams[] array = new TParams[(native_parms != null) ? native_parms.Length : 0];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = JavaConvert.FromJavaObject<TParams>((native_parms != null) ? native_parms[i] : null);
			}
			return JavaConvert.ToJavaObject<TResult>(this.RunInBackground(array)).JavaCast<Java.Lang.Object>();
		}

		// Token: 0x06001245 RID: 4677
		protected abstract TResult RunInBackground(params TParams[] @params);

		// Token: 0x06001246 RID: 4678 RVA: 0x000302F8 File Offset: 0x0002E4F8
		public AsyncTask<TParams, TProgress, TResult> Execute(params TParams[] @params)
		{
			if (AsyncTask<TParams, TProgress, TResult>.id_execute_arrayLjava_lang_Object_ == IntPtr.Zero)
			{
				AsyncTask<TParams, TProgress, TResult>.id_execute_arrayLjava_lang_Object_ = JNIEnv.GetMethodID(AsyncTask<TParams, TProgress, TResult>.class_ref, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			}
			IntPtr intPtr = JNIEnv.NewObjectArray<TParams>(@params);
			AsyncTask<TParams, TProgress, TResult> result;
			try
			{
				AsyncTask<TParams, TProgress, TResult> @object = Java.Lang.Object.GetObject<AsyncTask<TParams, TProgress, TResult>>(JNIEnv.CallObjectMethod(base.Handle, AsyncTask<TParams, TProgress, TResult>.id_execute_arrayLjava_lang_Object_, new JValue[]
				{
					new JValue(intPtr)
				}), JniHandleOwnership.TransferLocalRef);
				if (@params != null)
				{
					JNIEnv.CopyObjectArray<TParams>(intPtr, @params);
				}
				result = @object;
			}
			finally
			{
				if (@params != null)
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
			return result;
		}

		// Token: 0x0400083A RID: 2106
		private static IntPtr java_class_handle;

		// Token: 0x0400083B RID: 2107
		private static IntPtr id_ctor;

		// Token: 0x0400083C RID: 2108
		private static IntPtr id_execute_arrayLjava_lang_Object_;
	}
}
