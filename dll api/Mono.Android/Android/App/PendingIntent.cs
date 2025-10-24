using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000268 RID: 616
	[Register("android/app/PendingIntent", DoNotGenerateAcw = true)]
	public sealed class PendingIntent : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0003D6E3 File Offset: 0x0003B8E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PendingIntent._members;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0003D6EC File Offset: 0x0003B8EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PendingIntent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0003D710 File Offset: 0x0003B910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PendingIntent._members.ManagedPeerType;
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000021E0 File Offset: 0x000003E0
		internal PendingIntent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0003D71C File Offset: 0x0003B91C
		public int DescribeContents()
		{
			return PendingIntent._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0003D738 File Offset: 0x0003B938
		public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				PendingIntent._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000A11 RID: 2577
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/PendingIntent", typeof(PendingIntent));
	}
}
