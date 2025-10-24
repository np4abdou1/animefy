using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Views.Accessibility
{
	// Token: 0x02000187 RID: 391
	[Register("android/view/accessibility/AccessibilityEvent", DoNotGenerateAcw = true)]
	public sealed class AccessibilityEvent : AccessibilityRecord, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00022FE7 File Offset: 0x000211E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityEvent._members;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00022FF0 File Offset: 0x000211F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00023014 File Offset: 0x00021214
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00023020 File Offset: 0x00021220
		internal AccessibilityEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002302A File Offset: 0x0002122A
		public int DescribeContents()
		{
			return AccessibilityEvent._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00023044 File Offset: 0x00021244
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AccessibilityEvent._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000626 RID: 1574
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityEvent", typeof(AccessibilityEvent));
	}
}
