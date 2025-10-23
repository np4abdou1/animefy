using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Persistence
{
	// Token: 0x02000066 RID: 102
	[Register("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule", DoNotGenerateAcw = true)]
	public abstract class EventStoreModule : Java.Lang.Object
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000AB3C File Offset: 0x00008D3C
		internal static IntPtr class_ref
		{
			get
			{
				return EventStoreModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000AB60 File Offset: 0x00008D60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EventStoreModule._members;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000AB68 File Offset: 0x00008D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EventStoreModule._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000AB8C File Offset: 0x00008D8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EventStoreModule._members.ManagedPeerType;
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000026C4 File Offset: 0x000008C4
		protected EventStoreModule(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000AB98 File Offset: 0x00008D98
		[Register(".ctor", "()V", "")]
		public EventStoreModule() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(EventStoreModule._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			EventStoreModule._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x040000BE RID: 190
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/persistence/EventStoreModule", typeof(EventStoreModule));
	}
}
