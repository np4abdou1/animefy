using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x02000124 RID: 292
	[Register("android/view/InputEvent", DoNotGenerateAcw = true)]
	internal class InputEventInvoker : InputEvent
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x000150C1 File Offset: 0x000132C1
		public InputEventInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000150CB File Offset: 0x000132CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputEventInvoker._members;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000150D2 File Offset: 0x000132D2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputEventInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000150E0 File Offset: 0x000132E0
		public unsafe override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				InputEventInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x040002A7 RID: 679
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/InputEvent", typeof(InputEventInvoker));
	}
}
