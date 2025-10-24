using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200003D RID: 61
	[Register("com/google/android/gms/common/api/internal/UnregisterListenerMethod", DoNotGenerateAcw = true)]
	internal class UnregisterListenerMethodInvoker : UnregisterListenerMethod
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00007E37 File Offset: 0x00006037
		public UnregisterListenerMethodInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00007E41 File Offset: 0x00006041
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnregisterListenerMethodInvoker._members;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00007E48 File Offset: 0x00006048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnregisterListenerMethodInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00007E54 File Offset: 0x00006054
		[Register("unregisterListener", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetUnregisterListener_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected unsafe override void UnregisterListener(Java.Lang.Object p0, TaskCompletionSource p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				UnregisterListenerMethodInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("unregisterListener.(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/UnregisterListenerMethod", typeof(UnregisterListenerMethodInvoker));
	}
}
