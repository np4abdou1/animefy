using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F4 RID: 500
	[Register("android/os/UserHandle", DoNotGenerateAcw = true)]
	public sealed class UserHandle : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000300C7 File Offset: 0x0002E2C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UserHandle._members;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000300D0 File Offset: 0x0002E2D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UserHandle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000300F4 File Offset: 0x0002E2F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UserHandle._members.ManagedPeerType;
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000021E0 File Offset: 0x000003E0
		internal UserHandle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00030100 File Offset: 0x0002E300
		public int DescribeContents()
		{
			return UserHandle._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0003011C File Offset: 0x0002E31C
		public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				UserHandle._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000810 RID: 2064
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/UserHandle", typeof(UserHandle));
	}
}
