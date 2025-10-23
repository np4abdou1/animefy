using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Net
{
	// Token: 0x020001FC RID: 508
	[Register("android/net/Uri", DoNotGenerateAcw = true)]
	internal class UriInvoker : Uri, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x00030663 File Offset: 0x0002E863
		public UriInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0003066D File Offset: 0x0002E86D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UriInvoker._members;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00030674 File Offset: 0x0002E874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UriInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00030680 File Offset: 0x0002E880
		public override string ToString()
		{
			return JNIEnv.GetString(UriInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000306B2 File Offset: 0x0002E8B2
		public override int DescribeContents()
		{
			return UriInvoker._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000306CC File Offset: 0x0002E8CC
		public unsafe override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				UriInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000844 RID: 2116
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/net/Uri", typeof(UriInvoker));
	}
}
