using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x0200026A RID: 618
	[Register("android/app/SearchableInfo", DoNotGenerateAcw = true)]
	public sealed class SearchableInfo : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0003D8B3 File Offset: 0x0003BAB3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SearchableInfo._members;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0003D8BC File Offset: 0x0003BABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SearchableInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0003D8E0 File Offset: 0x0003BAE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SearchableInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000021E0 File Offset: 0x000003E0
		internal SearchableInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0003D8EC File Offset: 0x0003BAEC
		public int DescribeContents()
		{
			return SearchableInfo._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0003D908 File Offset: 0x0003BB08
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				SearchableInfo._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A13 RID: 2579
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/SearchableInfo", typeof(SearchableInfo));
	}
}
