using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000229 RID: 553
	[Register("android/graphics/PointF", DoNotGenerateAcw = true)]
	public class PointF : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00032C9F File Offset: 0x00030E9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PointF._members;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00032CA8 File Offset: 0x00030EA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PointF._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x00032CCC File Offset: 0x00030ECC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PointF._members.ManagedPeerType;
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PointF(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00032CD8 File Offset: 0x00030ED8
		private static Delegate GetDescribeContentsHandler()
		{
			if (PointF.cb_describeContents == null)
			{
				PointF.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(PointF.n_DescribeContents));
			}
			return PointF.cb_describeContents;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00032CFC File Offset: 0x00030EFC
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PointF>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00032D0B File Offset: 0x00030F0B
		public virtual int DescribeContents()
		{
			return PointF._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00032D24 File Offset: 0x00030F24
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (PointF.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				PointF.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(PointF.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return PointF.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00032D48 File Offset: 0x00030F48
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			PointF @object = Java.Lang.Object.GetObject<PointF>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00032D70 File Offset: 0x00030F70
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				PointF._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x040008A5 RID: 2213
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/PointF", typeof(PointF));

		// Token: 0x040008A6 RID: 2214
		private static Delegate cb_describeContents;

		// Token: 0x040008A7 RID: 2215
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
