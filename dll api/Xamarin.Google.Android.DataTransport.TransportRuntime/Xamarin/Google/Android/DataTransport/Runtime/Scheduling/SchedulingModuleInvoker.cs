using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling
{
	// Token: 0x0200004D RID: 77
	[Register("com/google/android/datatransport/runtime/scheduling/SchedulingModule", DoNotGenerateAcw = true)]
	internal class SchedulingModuleInvoker : SchedulingModule
	{
		// Token: 0x06000260 RID: 608 RVA: 0x000075B1 File Offset: 0x000057B1
		public SchedulingModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000261 RID: 609 RVA: 0x000075BB File Offset: 0x000057BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SchedulingModuleInvoker._members;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000075C2 File Offset: 0x000057C2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SchedulingModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/SchedulingModule", typeof(SchedulingModuleInvoker));
	}
}
