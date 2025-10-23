using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.PM
{
	// Token: 0x020002B0 RID: 688
	[Register("android/content/pm/ShortcutInfo", DoNotGenerateAcw = true, ApiSince = 25)]
	public sealed class ShortcutInfo : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x000447AB File Offset: 0x000429AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShortcutInfo._members;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x000447B4 File Offset: 0x000429B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShortcutInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x000447D8 File Offset: 0x000429D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShortcutInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ShortcutInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000447E4 File Offset: 0x000429E4
		public int DescribeContents()
		{
			return ShortcutInfo._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00044800 File Offset: 0x00042A00
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ShortcutInfo._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000B38 RID: 2872
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/pm/ShortcutInfo", typeof(ShortcutInfo));
	}
}
