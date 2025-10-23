using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F3 RID: 499
	[Register("android/os/PersistableBundle", DoNotGenerateAcw = true)]
	public sealed class PersistableBundle : BaseBundle, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0002FFDF File Offset: 0x0002E1DF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PersistableBundle._members;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PersistableBundle._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0003000C File Offset: 0x0002E20C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PersistableBundle._members.ManagedPeerType;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0002E104 File Offset: 0x0002C304
		internal PersistableBundle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00030018 File Offset: 0x0002E218
		public int DescribeContents()
		{
			return PersistableBundle._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00030034 File Offset: 0x0002E234
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				PersistableBundle._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x0400080F RID: 2063
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/PersistableBundle", typeof(PersistableBundle));
	}
}
