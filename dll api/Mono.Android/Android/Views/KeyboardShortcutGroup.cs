using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200012E RID: 302
	[Register("android/view/KeyboardShortcutGroup", DoNotGenerateAcw = true, ApiSince = 24)]
	public sealed class KeyboardShortcutGroup : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000194F8 File Offset: 0x000176F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KeyboardShortcutGroup._members;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00019500 File Offset: 0x00017700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KeyboardShortcutGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00019524 File Offset: 0x00017724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KeyboardShortcutGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000021E0 File Offset: 0x000003E0
		internal KeyboardShortcutGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00019530 File Offset: 0x00017730
		public int DescribeContents()
		{
			return KeyboardShortcutGroup._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001954C File Offset: 0x0001774C
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				KeyboardShortcutGroup._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x0400034C RID: 844
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/KeyboardShortcutGroup", typeof(KeyboardShortcutGroup));
	}
}
