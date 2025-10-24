using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x0200004A RID: 74
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule", DoNotGenerateAcw = true)]
	internal class SchedulingConfigModuleInvoker : SchedulingConfigModule
	{
		// Token: 0x0600024B RID: 587 RVA: 0x00007241 File Offset: 0x00005441
		public SchedulingConfigModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000724B File Offset: 0x0000544B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingConfigModuleInvoker._members;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00007252 File Offset: 0x00005452
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingConfigModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingConfigModule", typeof(SchedulingConfigModuleInvoker));
	}
}
