using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x020002A2 RID: 674
	[Register("android/content/LocusId", DoNotGenerateAcw = true, ApiSince = 29)]
	public sealed class LocusId : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00043A3B File Offset: 0x00041C3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocusId._members;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00043A44 File Offset: 0x00041C44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocusId._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00043A68 File Offset: 0x00041C68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocusId._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x000021E0 File Offset: 0x000003E0
		internal LocusId(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00043A74 File Offset: 0x00041C74
		public int DescribeContents()
		{
			return LocusId._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00043A90 File Offset: 0x00041C90
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				LocusId._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000AE5 RID: 2789
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/LocusId", typeof(LocusId));
	}
}
