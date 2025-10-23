using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Internal.SafeParcel
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", DoNotGenerateAcw = true)]
	public abstract class AbstractSafeParcelable : Java.Lang.Object, ISafeParcelable, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002E64 File Offset: 0x00001064
		internal static IntPtr class_ref
		{
			get
			{
				return AbstractSafeParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002E88 File Offset: 0x00001088
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractSafeParcelable._members;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002E90 File Offset: 0x00001090
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractSafeParcelable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002EB4 File Offset: 0x000010B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractSafeParcelable._members.ManagedPeerType;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002EC0 File Offset: 0x000010C0
		protected AbstractSafeParcelable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002ECC File Offset: 0x000010CC
		[Register(".ctor", "()V", "")]
		public AbstractSafeParcelable() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AbstractSafeParcelable._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AbstractSafeParcelable._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002F3A File Offset: 0x0000113A
		[Register("describeContents", "()I", "")]
		public int DescribeContents()
		{
			return AbstractSafeParcelable._members.InstanceMethods.InvokeNonvirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002F53 File Offset: 0x00001153
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (AbstractSafeParcelable.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				AbstractSafeParcelable.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AbstractSafeParcelable.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return AbstractSafeParcelable.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002F78 File Offset: 0x00001178
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			AbstractSafeParcelable @object = Java.Lang.Object.GetObject<AbstractSafeParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06000088 RID: 136
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags);

		// Token: 0x04000013 RID: 19
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/internal/safeparcel/AbstractSafeParcelable", typeof(AbstractSafeParcelable));

		// Token: 0x04000014 RID: 20
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
