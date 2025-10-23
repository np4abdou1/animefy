using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000266 RID: 614
	[Register("android/app/NotificationChannelGroup", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class NotificationChannelGroup : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0003D4FB File Offset: 0x0003B6FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationChannelGroup._members;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0003D504 File Offset: 0x0003B704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationChannelGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0003D528 File Offset: 0x0003B728
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationChannelGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000021E0 File Offset: 0x000003E0
		internal NotificationChannelGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0003D534 File Offset: 0x0003B734
		public int DescribeContents()
		{
			return NotificationChannelGroup._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0003D550 File Offset: 0x0003B750
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				NotificationChannelGroup._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A0E RID: 2574
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/NotificationChannelGroup", typeof(NotificationChannelGroup));
	}
}
