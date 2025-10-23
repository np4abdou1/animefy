using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000224 RID: 548
	[Register("android/graphics/Insets", DoNotGenerateAcw = true, ApiSince = 29)]
	public sealed class Insets : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x0003291B File Offset: 0x00030B1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Insets._members;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00032924 File Offset: 0x00030B24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Insets._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00032948 File Offset: 0x00030B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Insets._members.ManagedPeerType;
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Insets(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00032954 File Offset: 0x00030B54
		public int DescribeContents()
		{
			return Insets._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00032970 File Offset: 0x00030B70
		public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Insets._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x0400089E RID: 2206
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Insets", typeof(Insets));
	}
}
