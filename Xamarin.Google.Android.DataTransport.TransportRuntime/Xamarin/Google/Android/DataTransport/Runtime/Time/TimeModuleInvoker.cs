using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Time
{
	// Token: 0x0200003A RID: 58
	[Register("com/google/android/datatransport/runtime/time/TimeModule", DoNotGenerateAcw = true)]
	internal class TimeModuleInvoker : TimeModule
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00005D59 File Offset: 0x00003F59
		public TimeModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00005D63 File Offset: 0x00003F63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeModuleInvoker._members;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00005D6A File Offset: 0x00003F6A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/time/TimeModule", typeof(TimeModuleInvoker));
	}
}
