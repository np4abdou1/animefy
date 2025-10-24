using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Accessibility
{
	// Token: 0x0200018B RID: 395
	[Register("android/view/accessibility/AccessibilityWindowInfo", DoNotGenerateAcw = true)]
	public sealed class AccessibilityWindowInfo : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000232E3 File Offset: 0x000214E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityWindowInfo._members;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x000232EC File Offset: 0x000214EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityWindowInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00023310 File Offset: 0x00021510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityWindowInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000021E0 File Offset: 0x000003E0
		internal AccessibilityWindowInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002331C File Offset: 0x0002151C
		public int DescribeContents()
		{
			return AccessibilityWindowInfo._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00023338 File Offset: 0x00021538
		public unsafe void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AccessibilityWindowInfo._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x0400062C RID: 1580
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityWindowInfo", typeof(AccessibilityWindowInfo));
	}
}
