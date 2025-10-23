using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200006C RID: 108
	[Register("com/google/android/gms/common/api/PendingResult", DoNotGenerateAcw = true)]
	internal class PendingResultInvoker : PendingResult
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00004818 File Offset: 0x00002A18
		public PendingResultInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000DF04 File Offset: 0x0000C104
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PendingResultInvoker._members;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000DF0B File Offset: 0x0000C10B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PendingResultInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0000DF17 File Offset: 0x0000C117
		public override bool IsCanceled
		{
			[Register("isCanceled", "()Z", "GetIsCanceledHandler")]
			get
			{
				return PendingResultInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isCanceled.()Z", this, null);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000DF30 File Offset: 0x0000C130
		[Register("await", "()Lcom/google/android/gms/common/api/Result;", "GetAwaitHandler")]
		public override Java.Lang.Object Await()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(PendingResultInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("await.()Lcom/google/android/gms/common/api/Result;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000DF64 File Offset: 0x0000C164
		[Register("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public unsafe override Java.Lang.Object Await(long p0, TimeUnit p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(PendingResultInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("await.(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		[Register("cancel", "()V", "GetCancelHandler")]
		public override void Cancel()
		{
			PendingResultInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000E008 File Offset: 0x0000C208
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;)V", "GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_Handler")]
		public unsafe override void SetResultCallback(IResultCallback p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				PendingResultInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setResultCallback.(Lcom/google/android/gms/common/api/ResultCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000E070 File Offset: 0x0000C270
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler")]
		public unsafe override void SetResultCallback(IResultCallback p0, long p1, TimeUnit p2)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				PendingResultInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setResultCallback.(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p2);
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/PendingResult", typeof(PendingResultInvoker));
	}
}
