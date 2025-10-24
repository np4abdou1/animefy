using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200002E RID: 46
	[Register("com/google/android/datatransport/runtime/TransportRuntimeComponent", DoNotGenerateAcw = true)]
	internal class TransportRuntimeComponentInvoker : TransportRuntimeComponent
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00004C27 File Offset: 0x00002E27
		public TransportRuntimeComponentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00004C31 File Offset: 0x00002E31
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportRuntimeComponentInvoker._members;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00004C38 File Offset: 0x00002E38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportRuntimeComponentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportRuntimeComponent", typeof(TransportRuntimeComponentInvoker));
	}
}
