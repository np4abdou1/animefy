using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000C RID: 12
	[Register("com/google/android/datatransport/Event", DoNotGenerateAcw = true)]
	internal class EventInvoker : Event
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000026CF File Offset: 0x000008CF
		public EventInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000026D9 File Offset: 0x000008D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventInvoker._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000026E0 File Offset: 0x000008E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000026EC File Offset: 0x000008EC
		public override Integer Code
		{
			[Register("getCode", "()Ljava/lang/Integer;", "GetGetCodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(EventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCode.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002720 File Offset: 0x00000920
		public override Priority Priority
		{
			[Register("getPriority", "()Lcom/google/android/datatransport/Priority;", "GetGetPriorityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Priority>(EventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getPriority.()Lcom/google/android/datatransport/Priority;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002754 File Offset: 0x00000954
		protected override Java.Lang.Object RawPayload
		{
			[Register("getPayload", "()Ljava/lang/Object;", "GetGetPayloadHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(EventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getPayload.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Event", typeof(EventInvoker));
	}
}
