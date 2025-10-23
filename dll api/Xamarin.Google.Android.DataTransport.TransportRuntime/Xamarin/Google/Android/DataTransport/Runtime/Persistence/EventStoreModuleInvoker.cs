using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000067 RID: 103
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule", DoNotGenerateAcw = true)]
	internal class EventStoreModuleInvoker : EventStoreModule
	{
		// Token: 0x0600035D RID: 861 RVA: 0x0000AC21 File Offset: 0x00008E21
		public EventStoreModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000AC2B File Offset: 0x00008E2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModuleInvoker._members;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000AC32 File Offset: 0x00008E32
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule", typeof(EventStoreModuleInvoker));
	}
}
