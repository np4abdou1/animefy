using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001EE RID: 494
	[Register("android/os/LocaleList", DoNotGenerateAcw = true, ApiSince = 24)]
	public sealed class LocaleList : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0002FB55 File Offset: 0x0002DD55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocaleList._members;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LocaleList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0002FB80 File Offset: 0x0002DD80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocaleList._members.ManagedPeerType;
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000021E0 File Offset: 0x000003E0
		internal LocaleList(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0002FB8C File Offset: 0x0002DD8C
		public int DescribeContents()
		{
			return LocaleList._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags parcelableFlags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)parcelableFlags);
				LocaleList._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000807 RID: 2055
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/LocaleList", typeof(LocaleList));
	}
}
