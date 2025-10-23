using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200022E RID: 558
	[Register("android/graphics/Region", DoNotGenerateAcw = true)]
	public class Region : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00033127 File Offset: 0x00031327
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Region._members;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00033130 File Offset: 0x00031330
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Region._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00033154 File Offset: 0x00031354
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Region._members.ManagedPeerType;
			}
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Region(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00033160 File Offset: 0x00031360
		private static Delegate GetDescribeContentsHandler()
		{
			if (Region.cb_describeContents == null)
			{
				Region.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Region.n_DescribeContents));
			}
			return Region.cb_describeContents;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x00033184 File Offset: 0x00031384
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Region>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00033193 File Offset: 0x00031393
		public virtual int DescribeContents()
		{
			return Region._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000331AC File Offset: 0x000313AC
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Region.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Region.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Region.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Region.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000331D0 File Offset: 0x000313D0
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p, int native_flags)
		{
			Region @object = Java.Lang.Object.GetObject<Region>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_p, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000331F8 File Offset: 0x000313F8
		public unsafe virtual void WriteToParcel(Parcel p, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Region._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p);
			}
		}

		// Token: 0x040008AE RID: 2222
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Region", typeof(Region));

		// Token: 0x040008AF RID: 2223
		private static Delegate cb_describeContents;

		// Token: 0x040008B0 RID: 2224
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
