using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Internal.SafeParcel
{
	// Token: 0x02000017 RID: 23
	[Register("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", DoNotGenerateAcw = true)]
	internal class AbstractSafeParcelableInvoker : AbstractSafeParcelable
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000210C File Offset: 0x0000030C
		public AbstractSafeParcelableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002FB9 File Offset: 0x000011B9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractSafeParcelableInvoker._members;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002FC0 File Offset: 0x000011C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractSafeParcelableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002FCC File Offset: 0x000011CC
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public unsafe override void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AbstractSafeParcelableInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", typeof(AbstractSafeParcelableInvoker));
	}
}
