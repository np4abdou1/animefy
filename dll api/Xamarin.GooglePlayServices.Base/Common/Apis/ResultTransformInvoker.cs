using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200006E RID: 110
	[Register("com/google/android/gms/common/api/ResultTransform", DoNotGenerateAcw = true)]
	internal class ResultTransformInvoker : ResultTransform
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x0000E39B File Offset: 0x0000C59B
		public ResultTransformInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000E3A5 File Offset: 0x0000C5A5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultTransformInvoker._members;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultTransformInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Register("onSuccess", "(Lcom/google/android/gms/common/api/Result;)Lcom/google/android/gms/common/api/PendingResult;", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public unsafe override PendingResult OnSuccess(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			PendingResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PendingResult>(ResultTransformInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onSuccess.(Lcom/google/android/gms/common/api/Result;)Lcom/google/android/gms/common/api/PendingResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000120 RID: 288
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/ResultTransform", typeof(ResultTransformInvoker));
	}
}
