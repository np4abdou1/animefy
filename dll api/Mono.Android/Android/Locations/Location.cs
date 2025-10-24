using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Locations
{
	// Token: 0x0200020C RID: 524
	[Register("android/location/Location", DoNotGenerateAcw = true)]
	public class Location : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000317EF File Offset: 0x0002F9EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Location._members;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000317F8 File Offset: 0x0002F9F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Location._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0003181C File Offset: 0x0002FA1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Location._members.ManagedPeerType;
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Location(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00031828 File Offset: 0x0002FA28
		private static Delegate GetDescribeContentsHandler()
		{
			if (Location.cb_describeContents == null)
			{
				Location.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Location.n_DescribeContents));
			}
			return Location.cb_describeContents;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0003184C File Offset: 0x0002FA4C
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Location>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0003185B File Offset: 0x0002FA5B
		public virtual int DescribeContents()
		{
			return Location._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00031874 File Offset: 0x0002FA74
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Location.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Location.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Location.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Location.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00031898 File Offset: 0x0002FA98
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_flags)
		{
			Location @object = Java.Lang.Object.GetObject<Location>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_parcel, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000318C0 File Offset: 0x0002FAC0
		public unsafe virtual void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Location._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000872 RID: 2162
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/location/Location", typeof(Location));

		// Token: 0x04000873 RID: 2163
		private static Delegate cb_describeContents;

		// Token: 0x04000874 RID: 2164
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
