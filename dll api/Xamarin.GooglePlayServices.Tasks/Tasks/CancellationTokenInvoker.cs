using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x0200000C RID: 12
	[Register("com/google/android/gms/tasks/CancellationToken", DoNotGenerateAcw = true)]
	internal class CancellationTokenInvoker : CancellationToken
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00003583 File Offset: 0x00001783
		public CancellationTokenInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000358D File Offset: 0x0000178D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellationTokenInvoker._members;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003594 File Offset: 0x00001794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellationTokenInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000035A0 File Offset: 0x000017A0
		public override bool IsCancellationRequested
		{
			[Register("isCancellationRequested", "()Z", "GetIsCancellationRequestedHandler")]
			get
			{
				return CancellationTokenInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isCancellationRequested.()Z", this, null);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000035BC File Offset: 0x000017BC
		[Register("onCanceledRequested", "(Lcom/google/android/gms/tasks/OnTokenCanceledListener;)Lcom/google/android/gms/tasks/CancellationToken;", "GetOnCanceledRequested_Lcom_google_android_gms_tasks_OnTokenCanceledListener_Handler")]
		public unsafe override CancellationToken OnCanceledRequested(IOnTokenCanceledListener p0)
		{
			CancellationToken @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				@object = Java.Lang.Object.GetObject<CancellationToken>(CancellationTokenInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onCanceledRequested.(Lcom/google/android/gms/tasks/OnTokenCanceledListener;)Lcom/google/android/gms/tasks/CancellationToken;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x04000023 RID: 35
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/CancellationToken", typeof(CancellationTokenInvoker));
	}
}
