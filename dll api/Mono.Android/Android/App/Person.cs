using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000269 RID: 617
	[Register("android/app/Person", DoNotGenerateAcw = true, ApiSince = 28)]
	public sealed class Person : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x0003D7CB File Offset: 0x0003B9CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Person._members;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0003D7D4 File Offset: 0x0003B9D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Person._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Person._members.ManagedPeerType;
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Person(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0003D804 File Offset: 0x0003BA04
		public int DescribeContents()
		{
			return Person._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0003D820 File Offset: 0x0003BA20
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Person._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A12 RID: 2578
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Person", typeof(Person));
	}
}
