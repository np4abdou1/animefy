using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.Res
{
	// Token: 0x020002A8 RID: 680
	[Register("android/content/res/ColorStateList", DoNotGenerateAcw = true)]
	public class ColorStateList : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00043D40 File Offset: 0x00041F40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ColorStateList._members;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00043D48 File Offset: 0x00041F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ColorStateList._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00043D6C File Offset: 0x00041F6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ColorStateList._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ColorStateList(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00043D78 File Offset: 0x00041F78
		private static Delegate GetDescribeContentsHandler()
		{
			if (ColorStateList.cb_describeContents == null)
			{
				ColorStateList.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ColorStateList.n_DescribeContents));
			}
			return ColorStateList.cb_describeContents;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00043D9C File Offset: 0x00041F9C
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ColorStateList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00043DAB File Offset: 0x00041FAB
		public virtual int DescribeContents()
		{
			return ColorStateList._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00043DC4 File Offset: 0x00041FC4
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (ColorStateList.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				ColorStateList.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ColorStateList.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return ColorStateList.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00043DE8 File Offset: 0x00041FE8
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			ColorStateList @object = Java.Lang.Object.GetObject<ColorStateList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00043E10 File Offset: 0x00042010
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ColorStateList._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/ColorStateList", typeof(ColorStateList));

		// Token: 0x04000B22 RID: 2850
		private static Delegate cb_describeContents;

		// Token: 0x04000B23 RID: 2851
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
