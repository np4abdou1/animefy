using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F0 RID: 496
	[Register("android/os/Message", DoNotGenerateAcw = true)]
	public sealed class Message : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x0002FCF4 File Offset: 0x0002DEF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Message._members;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Message._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x0002FD20 File Offset: 0x0002DF20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Message._members.ManagedPeerType;
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Message(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0002FD2C File Offset: 0x0002DF2C
		public int DescribeContents()
		{
			return Message._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0002FD48 File Offset: 0x0002DF48
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Message._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000809 RID: 2057
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Message", typeof(Message));
	}
}
