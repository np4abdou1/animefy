using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App.Job;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000055 RID: 85
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig", DoNotGenerateAcw = true)]
	public abstract class SchedulerConfig : Java.Lang.Object
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00008710 File Offset: 0x00006910
		internal static IntPtr class_ref
		{
			get
			{
				return SchedulerConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00008734 File Offset: 0x00006934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulerConfig._members;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000873C File Offset: 0x0000693C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SchedulerConfig._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00008760 File Offset: 0x00006960
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulerConfig._members.ManagedPeerType;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000026C4 File Offset: 0x000008C4
		protected SchedulerConfig(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000876C File Offset: 0x0000696C
		[Register(".ctor", "()V", "")]
		public SchedulerConfig() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SchedulerConfig._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SchedulerConfig._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000087DC File Offset: 0x000069DC
		[Register("builder", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", "")]
		public static SchedulerConfig.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<SchedulerConfig.Builder>(SchedulerConfig._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000880D File Offset: 0x00006A0D
		private static Delegate GetConfigureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JIHandler()
		{
			if (SchedulerConfig.cb_configureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI == null)
			{
				SchedulerConfig.cb_configureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJI_L(SchedulerConfig.n_ConfigureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI));
			}
			return SchedulerConfig.cb_configureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00008834 File Offset: 0x00006A34
		private static IntPtr n_ConfigureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI(IntPtr jnienv, IntPtr native__this, IntPtr native_builder, IntPtr native_priority, long minimumTimestamp, int attemptNumber)
		{
			SchedulerConfig @object = Java.Lang.Object.GetObject<SchedulerConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JobInfo.Builder object2 = Java.Lang.Object.GetObject<JobInfo.Builder>(native_builder, JniHandleOwnership.DoNotTransfer);
			Priority object3 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ConfigureJob(object2, object3, minimumTimestamp, attemptNumber));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000886C File Offset: 0x00006A6C
		[Register("configureJob", "(Landroid/app/job/JobInfo$Builder;Lcom/google/android/datatransport/Priority;JI)Landroid/app/job/JobInfo$Builder;", "GetConfigureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JIHandler")]
		public unsafe virtual JobInfo.Builder ConfigureJob(JobInfo.Builder builder, Priority priority, long minimumTimestamp, int attemptNumber)
		{
			JobInfo.Builder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
				ptr[1] = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[2] = new JniArgumentValue(minimumTimestamp);
				ptr[3] = new JniArgumentValue(attemptNumber);
				@object = Java.Lang.Object.GetObject<JobInfo.Builder>(SchedulerConfig._members.InstanceMethods.InvokeVirtualObjectMethod("configureJob.(Landroid/app/job/JobInfo$Builder;Lcom/google/android/datatransport/Priority;JI)Landroid/app/job/JobInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(builder);
				GC.KeepAlive(priority);
			}
			return @object;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008934 File Offset: 0x00006B34
		[Register("getDefault", "(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", "")]
		public unsafe static SchedulerConfig GetDefault(IClock clock)
		{
			SchedulerConfig @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
				@object = Java.Lang.Object.GetObject<SchedulerConfig>(SchedulerConfig._members.StaticMethods.InvokeObjectMethod("getDefault.(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(clock);
			}
			return @object;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000089AC File Offset: 0x00006BAC
		private static Delegate GetGetFlags_Lcom_google_android_datatransport_Priority_Handler()
		{
			if (SchedulerConfig.cb_getFlags_Lcom_google_android_datatransport_Priority_ == null)
			{
				SchedulerConfig.cb_getFlags_Lcom_google_android_datatransport_Priority_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SchedulerConfig.n_GetFlags_Lcom_google_android_datatransport_Priority_));
			}
			return SchedulerConfig.cb_getFlags_Lcom_google_android_datatransport_Priority_;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000089D0 File Offset: 0x00006BD0
		private static IntPtr n_GetFlags_Lcom_google_android_datatransport_Priority_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority)
		{
			SchedulerConfig @object = Java.Lang.Object.GetObject<SchedulerConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			return JavaSet<SchedulerConfig.Flag>.ToLocalJniHandle(@object.GetFlags(object2));
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000089F8 File Offset: 0x00006BF8
		[Register("getFlags", "(Lcom/google/android/datatransport/Priority;)Ljava/util/Set;", "GetGetFlags_Lcom_google_android_datatransport_Priority_Handler")]
		public unsafe virtual ICollection<SchedulerConfig.Flag> GetFlags(Priority priority)
		{
			ICollection<SchedulerConfig.Flag> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				result = JavaSet<SchedulerConfig.Flag>.FromJniHandle(SchedulerConfig._members.InstanceMethods.InvokeVirtualObjectMethod("getFlags.(Lcom/google/android/datatransport/Priority;)Ljava/util/Set;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return result;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008A6C File Offset: 0x00006C6C
		private static Delegate GetGetScheduleDelay_Lcom_google_android_datatransport_Priority_JIHandler()
		{
			if (SchedulerConfig.cb_getScheduleDelay_Lcom_google_android_datatransport_Priority_JI == null)
			{
				SchedulerConfig.cb_getScheduleDelay_Lcom_google_android_datatransport_Priority_JI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJI_J(SchedulerConfig.n_GetScheduleDelay_Lcom_google_android_datatransport_Priority_JI));
			}
			return SchedulerConfig.cb_getScheduleDelay_Lcom_google_android_datatransport_Priority_JI;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008A90 File Offset: 0x00006C90
		private static long n_GetScheduleDelay_Lcom_google_android_datatransport_Priority_JI(IntPtr jnienv, IntPtr native__this, IntPtr native_priority, long minTimestamp, int attemptNumber)
		{
			SchedulerConfig @object = Java.Lang.Object.GetObject<SchedulerConfig>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
			return @object.GetScheduleDelay(object2, minTimestamp, attemptNumber);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008AB8 File Offset: 0x00006CB8
		[Register("getScheduleDelay", "(Lcom/google/android/datatransport/Priority;JI)J", "GetGetScheduleDelay_Lcom_google_android_datatransport_Priority_JIHandler")]
		public unsafe virtual long GetScheduleDelay(Priority priority, long minTimestamp, int attemptNumber)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				ptr[1] = new JniArgumentValue(minTimestamp);
				ptr[2] = new JniArgumentValue(attemptNumber);
				result = SchedulerConfig._members.InstanceMethods.InvokeVirtualInt64Method("getScheduleDelay.(Lcom/google/android/datatransport/Priority;JI)J", this, ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return result;
		}

		// Token: 0x0400009B RID: 155
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig", typeof(SchedulerConfig));

		// Token: 0x0400009C RID: 156
		private static Delegate cb_configureJob_Landroid_app_job_JobInfo_Builder_Lcom_google_android_datatransport_Priority_JI;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_getFlags_Lcom_google_android_datatransport_Priority_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_getScheduleDelay_Lcom_google_android_datatransport_Priority_JI;

		// Token: 0x02000056 RID: 86
		[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x00008B64 File Offset: 0x00006D64
			internal static IntPtr class_ref
			{
				get
				{
					return SchedulerConfig.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x00008B88 File Offset: 0x00006D88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SchedulerConfig.Builder._members;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x00008B90 File Offset: 0x00006D90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SchedulerConfig.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x00008BB4 File Offset: 0x00006DB4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SchedulerConfig.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x000026C4 File Offset: 0x000008C4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00008BC0 File Offset: 0x00006DC0
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(SchedulerConfig.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				SchedulerConfig.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00008C2E File Offset: 0x00006E2E
			private static Delegate GetAddConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_Handler()
			{
				if (SchedulerConfig.Builder.cb_addConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_ == null)
				{
					SchedulerConfig.Builder.cb_addConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SchedulerConfig.Builder.n_AddConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_));
				}
				return SchedulerConfig.Builder.cb_addConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_;
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00008C54 File Offset: 0x00006E54
			private static IntPtr n_AddConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_(IntPtr jnienv, IntPtr native__this, IntPtr native_priority, IntPtr native_value)
			{
				SchedulerConfig.Builder @object = Java.Lang.Object.GetObject<SchedulerConfig.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Priority object2 = Java.Lang.Object.GetObject<Priority>(native_priority, JniHandleOwnership.DoNotTransfer);
				SchedulerConfig.ConfigValue object3 = Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue>(native_value, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddConfig(object2, object3));
			}

			// Token: 0x060002CA RID: 714 RVA: 0x00008C88 File Offset: 0x00006E88
			[Register("addConfig", "(Lcom/google/android/datatransport/Priority;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", "GetAddConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_Handler")]
			public unsafe virtual SchedulerConfig.Builder AddConfig(Priority priority, SchedulerConfig.ConfigValue value)
			{
				SchedulerConfig.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
					ptr[1] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					@object = Java.Lang.Object.GetObject<SchedulerConfig.Builder>(SchedulerConfig.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addConfig.(Lcom/google/android/datatransport/Priority;Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(priority);
					GC.KeepAlive(value);
				}
				return @object;
			}

			// Token: 0x060002CB RID: 715 RVA: 0x00008D24 File Offset: 0x00006F24
			private static Delegate GetBuildHandler()
			{
				if (SchedulerConfig.Builder.cb_build == null)
				{
					SchedulerConfig.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SchedulerConfig.Builder.n_Build));
				}
				return SchedulerConfig.Builder.cb_build;
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00008D48 File Offset: 0x00006F48
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SchedulerConfig.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060002CD RID: 717 RVA: 0x00008D5C File Offset: 0x00006F5C
			[Register("build", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", "GetBuildHandler")]
			public virtual SchedulerConfig Build()
			{
				return Java.Lang.Object.GetObject<SchedulerConfig>(SchedulerConfig.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x00008D8E File Offset: 0x00006F8E
			private static Delegate GetSetClock_Lcom_google_android_datatransport_runtime_time_Clock_Handler()
			{
				if (SchedulerConfig.Builder.cb_setClock_Lcom_google_android_datatransport_runtime_time_Clock_ == null)
				{
					SchedulerConfig.Builder.cb_setClock_Lcom_google_android_datatransport_runtime_time_Clock_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SchedulerConfig.Builder.n_SetClock_Lcom_google_android_datatransport_runtime_time_Clock_));
				}
				return SchedulerConfig.Builder.cb_setClock_Lcom_google_android_datatransport_runtime_time_Clock_;
			}

			// Token: 0x060002CF RID: 719 RVA: 0x00008DB4 File Offset: 0x00006FB4
			private static IntPtr n_SetClock_Lcom_google_android_datatransport_runtime_time_Clock_(IntPtr jnienv, IntPtr native__this, IntPtr native_clock)
			{
				SchedulerConfig.Builder @object = Java.Lang.Object.GetObject<SchedulerConfig.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IClock object2 = Java.Lang.Object.GetObject<IClock>(native_clock, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClock(object2));
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00008DDC File Offset: 0x00006FDC
			[Register("setClock", "(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", "GetSetClock_Lcom_google_android_datatransport_runtime_time_Clock_Handler")]
			public unsafe virtual SchedulerConfig.Builder SetClock(IClock clock)
			{
				SchedulerConfig.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((clock == null) ? IntPtr.Zero : ((Java.Lang.Object)clock).Handle);
					@object = Java.Lang.Object.GetObject<SchedulerConfig.Builder>(SchedulerConfig.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setClock.(Lcom/google/android/datatransport/runtime/time/Clock;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(clock);
				}
				return @object;
			}

			// Token: 0x0400009F RID: 159
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Builder", typeof(SchedulerConfig.Builder));

			// Token: 0x040000A0 RID: 160
			private static Delegate cb_addConfig_Lcom_google_android_datatransport_Priority_Lcom_google_android_datatransport_runtime_scheduling_jobscheduling_SchedulerConfig_ConfigValue_;

			// Token: 0x040000A1 RID: 161
			private static Delegate cb_build;

			// Token: 0x040000A2 RID: 162
			private static Delegate cb_setClock_Lcom_google_android_datatransport_runtime_time_Clock_;
		}

		// Token: 0x02000057 RID: 87
		[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue", DoNotGenerateAcw = true)]
		public abstract class ConfigValue : Java.Lang.Object
		{
			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x00008E70 File Offset: 0x00007070
			internal static IntPtr class_ref
			{
				get
				{
					return SchedulerConfig.ConfigValue._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002D3 RID: 723 RVA: 0x00008E94 File Offset: 0x00007094
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SchedulerConfig.ConfigValue._members;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002D4 RID: 724 RVA: 0x00008E9C File Offset: 0x0000709C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SchedulerConfig.ConfigValue._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002D5 RID: 725 RVA: 0x00008EC0 File Offset: 0x000070C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SchedulerConfig.ConfigValue._members.ManagedPeerType;
				}
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x000026C4 File Offset: 0x000008C4
			protected ConfigValue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00008ECC File Offset: 0x000070CC
			[Register(".ctor", "()V", "")]
			public ConfigValue() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(SchedulerConfig.ConfigValue._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				SchedulerConfig.ConfigValue._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00008F3C File Offset: 0x0000713C
			[Register("builder", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "")]
			public static SchedulerConfig.ConfigValue.Builder InvokeBuilder()
			{
				return Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(SchedulerConfig.ConfigValue._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040000A3 RID: 163
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue", typeof(SchedulerConfig.ConfigValue));

			// Token: 0x02000058 RID: 88
			[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder", DoNotGenerateAcw = true)]
			public abstract class Builder : Java.Lang.Object
			{
				// Token: 0x170000DD RID: 221
				// (get) Token: 0x060002DA RID: 730 RVA: 0x00008F88 File Offset: 0x00007188
				internal static IntPtr class_ref
				{
					get
					{
						return SchedulerConfig.ConfigValue.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000DE RID: 222
				// (get) Token: 0x060002DB RID: 731 RVA: 0x00008FAC File Offset: 0x000071AC
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return SchedulerConfig.ConfigValue.Builder._members;
					}
				}

				// Token: 0x170000DF RID: 223
				// (get) Token: 0x060002DC RID: 732 RVA: 0x00008FB4 File Offset: 0x000071B4
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override IntPtr ThresholdClass
				{
					get
					{
						return SchedulerConfig.ConfigValue.Builder._members.JniPeerType.PeerReference.Handle;
					}
				}

				// Token: 0x170000E0 RID: 224
				// (get) Token: 0x060002DD RID: 733 RVA: 0x00008FD8 File Offset: 0x000071D8
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return SchedulerConfig.ConfigValue.Builder._members.ManagedPeerType;
					}
				}

				// Token: 0x060002DE RID: 734 RVA: 0x000026C4 File Offset: 0x000008C4
				protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
				{
				}

				// Token: 0x060002DF RID: 735 RVA: 0x00008FE4 File Offset: 0x000071E4
				[Register(".ctor", "()V", "")]
				public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (base.Handle != IntPtr.Zero)
					{
						return;
					}
					base.SetHandle(SchedulerConfig.ConfigValue.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
					SchedulerConfig.ConfigValue.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
				}

				// Token: 0x060002E0 RID: 736 RVA: 0x00009052 File Offset: 0x00007252
				private static Delegate GetBuildHandler()
				{
					if (SchedulerConfig.ConfigValue.Builder.cb_build == null)
					{
						SchedulerConfig.ConfigValue.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SchedulerConfig.ConfigValue.Builder.n_Build));
					}
					return SchedulerConfig.ConfigValue.Builder.cb_build;
				}

				// Token: 0x060002E1 RID: 737 RVA: 0x00009076 File Offset: 0x00007276
				private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
				{
					return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
				}

				// Token: 0x060002E2 RID: 738
				[Register("build", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue;", "GetBuildHandler")]
				public abstract SchedulerConfig.ConfigValue Build();

				// Token: 0x060002E3 RID: 739 RVA: 0x0000908A File Offset: 0x0000728A
				private static Delegate GetSetDelta_JHandler()
				{
					if (SchedulerConfig.ConfigValue.Builder.cb_setDelta_J == null)
					{
						SchedulerConfig.ConfigValue.Builder.cb_setDelta_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(SchedulerConfig.ConfigValue.Builder.n_SetDelta_J));
					}
					return SchedulerConfig.ConfigValue.Builder.cb_setDelta_J;
				}

				// Token: 0x060002E4 RID: 740 RVA: 0x000090AE File Offset: 0x000072AE
				private static IntPtr n_SetDelta_J(IntPtr jnienv, IntPtr native__this, long p0)
				{
					return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDelta(p0));
				}

				// Token: 0x060002E5 RID: 741
				[Register("setDelta", "(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetDelta_JHandler")]
				public abstract SchedulerConfig.ConfigValue.Builder SetDelta(long p0);

				// Token: 0x060002E6 RID: 742 RVA: 0x000090C3 File Offset: 0x000072C3
				private static Delegate GetSetFlags_Ljava_util_Set_Handler()
				{
					if (SchedulerConfig.ConfigValue.Builder.cb_setFlags_Ljava_util_Set_ == null)
					{
						SchedulerConfig.ConfigValue.Builder.cb_setFlags_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(SchedulerConfig.ConfigValue.Builder.n_SetFlags_Ljava_util_Set_));
					}
					return SchedulerConfig.ConfigValue.Builder.cb_setFlags_Ljava_util_Set_;
				}

				// Token: 0x060002E7 RID: 743 RVA: 0x000090E8 File Offset: 0x000072E8
				private static IntPtr n_SetFlags_Ljava_util_Set_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
				{
					SchedulerConfig.ConfigValue.Builder @object = Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					ICollection<SchedulerConfig.Flag> flags = JavaSet<SchedulerConfig.Flag>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle(@object.SetFlags(flags));
				}

				// Token: 0x060002E8 RID: 744
				[Register("setFlags", "(Ljava/util/Set;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetFlags_Ljava_util_Set_Handler")]
				public abstract SchedulerConfig.ConfigValue.Builder SetFlags(ICollection<SchedulerConfig.Flag> p0);

				// Token: 0x060002E9 RID: 745 RVA: 0x00009110 File Offset: 0x00007310
				private static Delegate GetSetMaxAllowedDelay_JHandler()
				{
					if (SchedulerConfig.ConfigValue.Builder.cb_setMaxAllowedDelay_J == null)
					{
						SchedulerConfig.ConfigValue.Builder.cb_setMaxAllowedDelay_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(SchedulerConfig.ConfigValue.Builder.n_SetMaxAllowedDelay_J));
					}
					return SchedulerConfig.ConfigValue.Builder.cb_setMaxAllowedDelay_J;
				}

				// Token: 0x060002EA RID: 746 RVA: 0x00009134 File Offset: 0x00007334
				private static IntPtr n_SetMaxAllowedDelay_J(IntPtr jnienv, IntPtr native__this, long p0)
				{
					return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMaxAllowedDelay(p0));
				}

				// Token: 0x060002EB RID: 747
				[Register("setMaxAllowedDelay", "(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetMaxAllowedDelay_JHandler")]
				public abstract SchedulerConfig.ConfigValue.Builder SetMaxAllowedDelay(long p0);

				// Token: 0x040000A4 RID: 164
				private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder", typeof(SchedulerConfig.ConfigValue.Builder));

				// Token: 0x040000A5 RID: 165
				private static Delegate cb_build;

				// Token: 0x040000A6 RID: 166
				private static Delegate cb_setDelta_J;

				// Token: 0x040000A7 RID: 167
				private static Delegate cb_setFlags_Ljava_util_Set_;

				// Token: 0x040000A8 RID: 168
				private static Delegate cb_setMaxAllowedDelay_J;
			}

			// Token: 0x02000059 RID: 89
			[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder", DoNotGenerateAcw = true)]
			internal class BuilderInvoker : SchedulerConfig.ConfigValue.Builder
			{
				// Token: 0x060002ED RID: 749 RVA: 0x00009164 File Offset: 0x00007364
				public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
				{
				}

				// Token: 0x170000E1 RID: 225
				// (get) Token: 0x060002EE RID: 750 RVA: 0x0000916E File Offset: 0x0000736E
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				public override JniPeerMembers JniPeerMembers
				{
					get
					{
						return SchedulerConfig.ConfigValue.BuilderInvoker._members;
					}
				}

				// Token: 0x170000E2 RID: 226
				// (get) Token: 0x060002EF RID: 751 RVA: 0x00009175 File Offset: 0x00007375
				[DebuggerBrowsable(DebuggerBrowsableState.Never)]
				[EditorBrowsable(EditorBrowsableState.Never)]
				protected override Type ThresholdType
				{
					get
					{
						return SchedulerConfig.ConfigValue.BuilderInvoker._members.ManagedPeerType;
					}
				}

				// Token: 0x060002F0 RID: 752 RVA: 0x00009184 File Offset: 0x00007384
				[Register("build", "()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue;", "GetBuildHandler")]
				public override SchedulerConfig.ConfigValue Build()
				{
					return Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue>(SchedulerConfig.ConfigValue.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}

				// Token: 0x060002F1 RID: 753 RVA: 0x000091B8 File Offset: 0x000073B8
				[Register("setDelta", "(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetDelta_JHandler")]
				public unsafe override SchedulerConfig.ConfigValue.Builder SetDelta(long p0)
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(p0);
					return Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(SchedulerConfig.ConfigValue.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setDelta.(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}

				// Token: 0x060002F2 RID: 754 RVA: 0x00009204 File Offset: 0x00007404
				[Register("setFlags", "(Ljava/util/Set;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetFlags_Ljava_util_Set_Handler")]
				public unsafe override SchedulerConfig.ConfigValue.Builder SetFlags(ICollection<SchedulerConfig.Flag> p0)
				{
					IntPtr intPtr = JavaSet<SchedulerConfig.Flag>.ToLocalJniHandle(p0);
					SchedulerConfig.ConfigValue.Builder @object;
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue(intPtr);
						@object = Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(SchedulerConfig.ConfigValue.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setFlags.(Ljava/util/Set;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
						GC.KeepAlive(p0);
					}
					return @object;
				}

				// Token: 0x060002F3 RID: 755 RVA: 0x00009278 File Offset: 0x00007478
				[Register("setMaxAllowedDelay", "(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", "GetSetMaxAllowedDelay_JHandler")]
				public unsafe override SchedulerConfig.ConfigValue.Builder SetMaxAllowedDelay(long p0)
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(p0);
					return Java.Lang.Object.GetObject<SchedulerConfig.ConfigValue.Builder>(SchedulerConfig.ConfigValue.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setMaxAllowedDelay.(J)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}

				// Token: 0x040000A9 RID: 169
				private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue$Builder", typeof(SchedulerConfig.ConfigValue.BuilderInvoker));
			}
		}

		// Token: 0x0200005A RID: 90
		[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue", DoNotGenerateAcw = true)]
		internal class ConfigValueInvoker : SchedulerConfig.ConfigValue
		{
			// Token: 0x060002F5 RID: 757 RVA: 0x000092DC File Offset: 0x000074DC
			public ConfigValueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x000092E6 File Offset: 0x000074E6
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SchedulerConfig.ConfigValueInvoker._members;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002F7 RID: 759 RVA: 0x000092ED File Offset: 0x000074ED
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SchedulerConfig.ConfigValueInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040000AA RID: 170
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$ConfigValue", typeof(SchedulerConfig.ConfigValueInvoker));
		}

		// Token: 0x0200005B RID: 91
		[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag", DoNotGenerateAcw = true)]
		public sealed class Flag : Java.Lang.Enum
		{
			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x00009314 File Offset: 0x00007514
			[Register("DEVICE_CHARGING")]
			public static SchedulerConfig.Flag DeviceCharging
			{
				get
				{
					return Java.Lang.Object.GetObject<SchedulerConfig.Flag>(SchedulerConfig.Flag._members.StaticFields.GetObjectValue("DEVICE_CHARGING.Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060002FA RID: 762 RVA: 0x00009344 File Offset: 0x00007544
			[Register("DEVICE_IDLE")]
			public static SchedulerConfig.Flag DeviceIdle
			{
				get
				{
					return Java.Lang.Object.GetObject<SchedulerConfig.Flag>(SchedulerConfig.Flag._members.StaticFields.GetObjectValue("DEVICE_IDLE.Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060002FB RID: 763 RVA: 0x00009374 File Offset: 0x00007574
			[Register("NETWORK_UNMETERED")]
			public static SchedulerConfig.Flag NetworkUnmetered
			{
				get
				{
					return Java.Lang.Object.GetObject<SchedulerConfig.Flag>(SchedulerConfig.Flag._members.StaticFields.GetObjectValue("NETWORK_UNMETERED.Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060002FC RID: 764 RVA: 0x000093A4 File Offset: 0x000075A4
			internal static IntPtr class_ref
			{
				get
				{
					return SchedulerConfig.Flag._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060002FD RID: 765 RVA: 0x000093C8 File Offset: 0x000075C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SchedulerConfig.Flag._members;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060002FE RID: 766 RVA: 0x000093D0 File Offset: 0x000075D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return SchedulerConfig.Flag._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060002FF RID: 767 RVA: 0x000093F4 File Offset: 0x000075F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SchedulerConfig.Flag._members.ManagedPeerType;
				}
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00009400 File Offset: 0x00007600
			internal Flag(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000301 RID: 769 RVA: 0x0000940C File Offset: 0x0000760C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;", "")]
			public unsafe static SchedulerConfig.Flag ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				SchedulerConfig.Flag @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<SchedulerConfig.Flag>(SchedulerConfig.Flag._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000302 RID: 770 RVA: 0x00009478 File Offset: 0x00007678
			[Register("values", "()[Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;", "")]
			public static SchedulerConfig.Flag[] Values()
			{
				return (SchedulerConfig.Flag[])JNIEnv.GetArray(SchedulerConfig.Flag._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(SchedulerConfig.Flag));
			}

			// Token: 0x040000AB RID: 171
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig$Flag", typeof(SchedulerConfig.Flag));
		}
	}
}
