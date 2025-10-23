using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200003B RID: 59
	[Register("com/google/android/gms/common/api/internal/TaskApiCall", DoNotGenerateAcw = true)]
	internal class TaskApiCallInvoker : TaskApiCall
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00007B8C File Offset: 0x00005D8C
		public TaskApiCallInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007B96 File Offset: 0x00005D96
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskApiCallInvoker._members;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00007B9D File Offset: 0x00005D9D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskApiCallInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007BAC File Offset: 0x00005DAC
		[Register("doExecute", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected unsafe override void DoExecute(Java.Lang.Object p0, TaskCompletionSource p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				TaskApiCallInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("doExecute.(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/TaskApiCall", typeof(TaskApiCallInvoker));
	}
}
