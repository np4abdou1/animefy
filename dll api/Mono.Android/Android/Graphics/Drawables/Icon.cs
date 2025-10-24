using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x0200023D RID: 573
	[Register("android/graphics/drawable/Icon", DoNotGenerateAcw = true, ApiSince = 23)]
	public sealed class Icon : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00034974 File Offset: 0x00032B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Icon._members;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0003497C File Offset: 0x00032B7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Icon._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000349A0 File Offset: 0x00032BA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Icon._members.ManagedPeerType;
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Icon(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000349AC File Offset: 0x00032BAC
		public int DescribeContents()
		{
			return Icon._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000349C8 File Offset: 0x00032BC8
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Icon._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x040008E7 RID: 2279
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/Icon", typeof(Icon));
	}
}
