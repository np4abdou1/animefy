using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x020001FD RID: 509
	[Register("android/media/AudioAttributes", DoNotGenerateAcw = true)]
	public sealed class AudioAttributes : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0003075F File Offset: 0x0002E95F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AudioAttributes._members;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00030768 File Offset: 0x0002E968
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AudioAttributes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0003078C File Offset: 0x0002E98C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AudioAttributes._members.ManagedPeerType;
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000021E0 File Offset: 0x000003E0
		internal AudioAttributes(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00030798 File Offset: 0x0002E998
		public int DescribeContents()
		{
			return AudioAttributes._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000307B4 File Offset: 0x0002E9B4
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AudioAttributes._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000845 RID: 2117
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/AudioAttributes", typeof(AudioAttributes));
	}
}
