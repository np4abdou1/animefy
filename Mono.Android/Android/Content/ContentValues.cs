using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x02000283 RID: 643
	[Register("android/content/ContentValues", DoNotGenerateAcw = true)]
	public sealed class ContentValues : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x0003F34B File Offset: 0x0003D54B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentValues._members;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x0003F354 File Offset: 0x0003D554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContentValues._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x0003F378 File Offset: 0x0003D578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentValues._members.ManagedPeerType;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ContentValues(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0003F384 File Offset: 0x0003D584
		public int DescribeContents()
		{
			return ContentValues._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ContentValues._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000A56 RID: 2646
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ContentValues", typeof(ContentValues));
	}
}
