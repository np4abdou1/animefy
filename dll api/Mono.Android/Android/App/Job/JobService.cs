using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App.Job
{
	// Token: 0x02000278 RID: 632
	[Register("android/app/job/JobService", DoNotGenerateAcw = true)]
	public abstract class JobService : Service
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0003E177 File Offset: 0x0003C377
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobService._members;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0003E180 File Offset: 0x0003C380
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobService._members.ManagedPeerType;
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0003DBB2 File Offset: 0x0003BDB2
		protected JobService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0003E1B0 File Offset: 0x0003C3B0
		public unsafe sealed override IBinder OnBind(Intent intent)
		{
			IBinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<IBinder>(JobService._members.InstanceMethods.InvokeNonvirtualObjectMethod("onBind.(Landroid/content/Intent;)Landroid/os/IBinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0003E224 File Offset: 0x0003C424
		private static Delegate GetOnStartJob_Landroid_app_job_JobParameters_Handler()
		{
			if (JobService.cb_onStartJob_Landroid_app_job_JobParameters_ == null)
			{
				JobService.cb_onStartJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobService.n_OnStartJob_Landroid_app_job_JobParameters_));
			}
			return JobService.cb_onStartJob_Landroid_app_job_JobParameters_;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0003E248 File Offset: 0x0003C448
		private static bool n_OnStartJob_Landroid_app_job_JobParameters_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			JobService @object = Java.Lang.Object.GetObject<JobService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JobParameters object2 = Java.Lang.Object.GetObject<JobParameters>(native__params, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartJob(object2);
		}

		// Token: 0x060017FE RID: 6142
		public abstract bool OnStartJob(JobParameters @params);

		// Token: 0x060017FF RID: 6143 RVA: 0x0003E26B File Offset: 0x0003C46B
		private static Delegate GetOnStopJob_Landroid_app_job_JobParameters_Handler()
		{
			if (JobService.cb_onStopJob_Landroid_app_job_JobParameters_ == null)
			{
				JobService.cb_onStopJob_Landroid_app_job_JobParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(JobService.n_OnStopJob_Landroid_app_job_JobParameters_));
			}
			return JobService.cb_onStopJob_Landroid_app_job_JobParameters_;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0003E290 File Offset: 0x0003C490
		private static bool n_OnStopJob_Landroid_app_job_JobParameters_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			JobService @object = Java.Lang.Object.GetObject<JobService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JobParameters object2 = Java.Lang.Object.GetObject<JobParameters>(native__params, JniHandleOwnership.DoNotTransfer);
			return @object.OnStopJob(object2);
		}

		// Token: 0x06001801 RID: 6145
		public abstract bool OnStopJob(JobParameters @params);

		// Token: 0x04000A3C RID: 2620
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/job/JobService", typeof(JobService));

		// Token: 0x04000A3D RID: 2621
		private static Delegate cb_onStartJob_Landroid_app_job_JobParameters_;

		// Token: 0x04000A3E RID: 2622
		private static Delegate cb_onStopJob_Landroid_app_job_JobParameters_;
	}
}
