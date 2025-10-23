using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000036 RID: 54
	[Register("com/google/android/gms/common/api/internal/RegisterListenerMethod", DoNotGenerateAcw = true)]
	internal class RegisterListenerMethodInvoker : RegisterListenerMethod
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00006B75 File Offset: 0x00004D75
		public RegisterListenerMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00006B7F File Offset: 0x00004D7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RegisterListenerMethodInvoker._members;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00006B86 File Offset: 0x00004D86
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RegisterListenerMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006B94 File Offset: 0x00004D94
		[Register("registerListener", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetRegisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected unsafe override void RegisterListener(Java.Lang.Object p0, TaskCompletionSource p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				RegisterListenerMethodInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("registerListener.(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x04000065 RID: 101
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/RegisterListenerMethod", typeof(RegisterListenerMethodInvoker));
	}
}
