using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App.Job;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000054 RID: 84
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoSchedulerService", DoNotGenerateAcw = true)]
	public class JobInfoSchedulerService : JobService
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000084BC File Offset: 0x000066BC
		internal static IntPtr class_ref
		{
			get
			{
				return JobInfoSchedulerService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000084E0 File Offset: 0x000066E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobInfoSchedulerService._members;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000084E8 File Offset: 0x000066E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobInfoSchedulerService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000850C File Offset: 0x0000670C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobInfoSchedulerService._members.ManagedPeerType;
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00008518 File Offset: 0x00006718
		protected JobInfoSchedulerService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008524 File Offset: 0x00006724
		[Register(".ctor", "()V", "")]
		public JobInfoSchedulerService() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(JobInfoSchedulerService._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			JobInfoSchedulerService._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00008592 File Offset: 0x00006792
		private static Delegate GetOnStartJob_Landroid_app_job_JobParameters_Handler()
		{
			if (JobInfoSchedulerService.cb_onStartJob_Landroid_app_job_JobParameters_ == null)
			{
				JobInfoSchedulerService.cb_onStartJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobInfoSchedulerService.n_OnStartJob_Landroid_app_job_JobParameters_));
			}
			return JobInfoSchedulerService.cb_onStartJob_Landroid_app_job_JobParameters_;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000085B8 File Offset: 0x000067B8
		private static bool n_OnStartJob_Landroid_app_job_JobParameters_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			JobService @object = Java.Lang.Object.GetObject<JobInfoSchedulerService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JobParameters object2 = Java.Lang.Object.GetObject<JobParameters>(native__params, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartJob(object2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000085DC File Offset: 0x000067DC
		[Register("onStartJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStartJob_Landroid_app_job_JobParameters_Handler")]
		public unsafe override bool OnStartJob(JobParameters @params)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				result = JobInfoSchedulerService._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartJob.(Landroid/app/job/JobParameters;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00008644 File Offset: 0x00006844
		private static Delegate GetOnStopJob_Landroid_app_job_JobParameters_Handler()
		{
			if (JobInfoSchedulerService.cb_onStopJob_Landroid_app_job_JobParameters_ == null)
			{
				JobInfoSchedulerService.cb_onStopJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobInfoSchedulerService.n_OnStopJob_Landroid_app_job_JobParameters_));
			}
			return JobInfoSchedulerService.cb_onStopJob_Landroid_app_job_JobParameters_;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008668 File Offset: 0x00006868
		private static bool n_OnStopJob_Landroid_app_job_JobParameters_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			JobService @object = Java.Lang.Object.GetObject<JobInfoSchedulerService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JobParameters object2 = Java.Lang.Object.GetObject<JobParameters>(native__params, JniHandleOwnership.DoNotTransfer);
			return @object.OnStopJob(object2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000868C File Offset: 0x0000688C
		[Register("onStopJob", "(Landroid/app/job/JobParameters;)Z", "GetOnStopJob_Landroid_app_job_JobParameters_Handler")]
		public unsafe override bool OnStopJob(JobParameters @params)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				result = JobInfoSchedulerService._members.InstanceMethods.InvokeVirtualBooleanMethod("onStopJob.(Landroid/app/job/JobParameters;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@params);
			}
			return result;
		}

		// Token: 0x04000098 RID: 152
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/JobInfoSchedulerService", typeof(JobInfoSchedulerService));

		// Token: 0x04000099 RID: 153
		private static Delegate cb_onStartJob_Landroid_app_job_JobParameters_;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_onStopJob_Landroid_app_job_JobParameters_;
	}
}
