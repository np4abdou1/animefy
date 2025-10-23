using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x0200005C RID: 92
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig", DoNotGenerateAcw = true)]
	internal class SchedulerConfigInvoker : SchedulerConfig
	{
		// Token: 0x06000304 RID: 772 RVA: 0x000094D3 File Offset: 0x000076D3
		public SchedulerConfigInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000094DD File Offset: 0x000076DD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulerConfigInvoker._members;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000094E4 File Offset: 0x000076E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulerConfigInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000AC RID: 172
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/SchedulerConfig", typeof(SchedulerConfigInvoker));
	}
}
