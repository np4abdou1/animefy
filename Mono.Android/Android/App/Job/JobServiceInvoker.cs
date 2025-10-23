using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.App.Job
{
	// Token: 0x02000279 RID: 633
	[Register("android/app/job/JobService", DoNotGenerateAcw = true)]
	internal class JobServiceInvoker : JobService
	{
		// Token: 0x06001803 RID: 6147 RVA: 0x0003E2CE File Offset: 0x0003C4CE
		public JobServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0003E2D8 File Offset: 0x0003C4D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobServiceInvoker._members;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0003E2DF File Offset: 0x0003C4DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		public unsafe override bool OnStartJob(JobParameters @params)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				result = JobServiceInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onStartJob.(Landroid/app/job/JobParameters;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0003E354 File Offset: 0x0003C554
		public unsafe override bool OnStopJob(JobParameters @params)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				result = JobServiceInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onStopJob.(Landroid/app/job/JobParameters;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x04000A3F RID: 2623
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/job/JobService", typeof(JobServiceInvoker));
	}
}
