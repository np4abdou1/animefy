using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000088 RID: 136
	[Register("com/google/android/datatransport/runtime/backends/BackendRequest", DoNotGenerateAcw = true)]
	internal class BackendRequestInvoker : BackendRequest
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x0000F2A7 File Offset: 0x0000D4A7
		public BackendRequestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0000F2B1 File Offset: 0x0000D4B1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendRequestInvoker._members;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendRequestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		public override IIterable Events
		{
			[Register("getEvents", "()Ljava/lang/Iterable;", "GetGetEventsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IIterable>(BackendRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEvents.()Ljava/lang/Iterable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		[Register("getExtras", "()[B", "GetGetExtrasHandler")]
		public override byte[] GetExtras()
		{
			return (byte[])JNIEnv.GetArray(BackendRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExtras.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x04000111 RID: 273
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRequest", typeof(BackendRequestInvoker));
	}
}
