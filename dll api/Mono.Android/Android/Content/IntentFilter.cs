using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200029A RID: 666
	[Register("android/content/IntentFilter", DoNotGenerateAcw = true)]
	public class IntentFilter : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0004244E File Offset: 0x0004064E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntentFilter._members;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00042458 File Offset: 0x00040658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntentFilter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0004247C File Offset: 0x0004067C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntentFilter._members.ManagedPeerType;
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000021E0 File Offset: 0x000003E0
		protected IntentFilter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00042488 File Offset: 0x00040688
		public int DescribeContents()
		{
			return IntentFilter._members.InstanceMethods.InvokeNonvirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000424A4 File Offset: 0x000406A4
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				IntentFilter._members.InstanceMethods.InvokeNonvirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000AAF RID: 2735
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/IntentFilter", typeof(IntentFilter));
	}
}
