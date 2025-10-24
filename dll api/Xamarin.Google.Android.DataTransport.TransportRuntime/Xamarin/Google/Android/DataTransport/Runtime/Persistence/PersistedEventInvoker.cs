using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000071 RID: 113
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent", DoNotGenerateAcw = true)]
	internal class PersistedEventInvoker : PersistedEvent
	{
		// Token: 0x060003DF RID: 991 RVA: 0x0000C03B File Offset: 0x0000A23B
		public PersistedEventInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000C045 File Offset: 0x0000A245
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PersistedEventInvoker._members;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000C04C File Offset: 0x0000A24C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PersistedEventInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0000C058 File Offset: 0x0000A258
		public override EventInternal Event
		{
			[Register("getEvent", "()Lcom/google/android/datatransport/runtime/EventInternal;", "GetGetEventHandler")]
			get
			{
				return Java.Lang.Object.GetObject<EventInternal>(PersistedEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEvent.()Lcom/google/android/datatransport/runtime/EventInternal;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000C08A File Offset: 0x0000A28A
		public override long Id
		{
			[Register("getId", "()J", "GetGetIdHandler")]
			get
			{
				return PersistedEventInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getId.()J", this, null);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		public override TransportContext TransportContext
		{
			[Register("getTransportContext", "()Lcom/google/android/datatransport/runtime/TransportContext;", "GetGetTransportContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<TransportContext>(PersistedEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTransportContext.()Lcom/google/android/datatransport/runtime/TransportContext;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/PersistedEvent", typeof(PersistedEventInvoker));
	}
}
