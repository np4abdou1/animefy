using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200001F RID: 31
	[Register("com/google/android/datatransport/cct/internal/LogResponse", DoNotGenerateAcw = true)]
	internal class LogResponseInvoker : LogResponse
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000054CF File Offset: 0x000036CF
		public LogResponseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000054D9 File Offset: 0x000036D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogResponseInvoker._members;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000054E0 File Offset: 0x000036E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogResponseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000054EC File Offset: 0x000036EC
		public override long NextRequestWaitMillis
		{
			[Register("getNextRequestWaitMillis", "()J", "GetGetNextRequestWaitMillisHandler")]
			get
			{
				return LogResponseInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getNextRequestWaitMillis.()J", this, null);
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogResponse", typeof(LogResponseInvoker));
	}
}
