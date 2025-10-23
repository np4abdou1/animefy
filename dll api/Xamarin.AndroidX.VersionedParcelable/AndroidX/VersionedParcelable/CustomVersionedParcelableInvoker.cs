using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.VersionedParcelable
{
	// Token: 0x02000008 RID: 8
	[Register("androidx/versionedparcelable/CustomVersionedParcelable", DoNotGenerateAcw = true)]
	internal class CustomVersionedParcelableInvoker : CustomVersionedParcelable
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000222E File Offset: 0x0000042E
		public CustomVersionedParcelableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002238 File Offset: 0x00000438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CustomVersionedParcelableInvoker._members;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000223F File Offset: 0x0000043F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CustomVersionedParcelableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/versionedparcelable/CustomVersionedParcelable", typeof(CustomVersionedParcelableInvoker));
	}
}
