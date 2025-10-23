using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/android/gms/common/api/ResultCallbacks", DoNotGenerateAcw = true)]
	internal class ResultCallbacksInvoker : ResultCallbacks, IResultCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000037AA File Offset: 0x000019AA
		public ResultCallbacksInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000037B4 File Offset: 0x000019B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultCallbacksInvoker._members;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000037BB File Offset: 0x000019BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultCallbacksInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000037C8 File Offset: 0x000019C8
		[Register("onFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public unsafe override void OnFailure(Statuses p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ResultCallbacksInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onFailure.(Lcom/google/android/gms/common/api/Status;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000382C File Offset: 0x00001A2C
		[Register("onSuccess", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public unsafe override void OnSuccess(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ResultCallbacksInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSuccess.(Lcom/google/android/gms/common/api/Result;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000027 RID: 39
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/ResultCallbacks", typeof(ResultCallbacksInvoker));
	}
}
