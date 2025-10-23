using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200022D RID: 557
	[Register("android/graphics/RectF", DoNotGenerateAcw = true)]
	public class RectF : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00032FC3 File Offset: 0x000311C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RectF._members;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00032FCC File Offset: 0x000311CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RectF._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00032FF0 File Offset: 0x000311F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RectF._members.ManagedPeerType;
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x000021E0 File Offset: 0x000003E0
		protected RectF(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00032FFC File Offset: 0x000311FC
		private static Delegate GetDescribeContentsHandler()
		{
			if (RectF.cb_describeContents == null)
			{
				RectF.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RectF.n_DescribeContents));
			}
			return RectF.cb_describeContents;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00033020 File Offset: 0x00031220
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RectF>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0003302F File Offset: 0x0003122F
		public virtual int DescribeContents()
		{
			return RectF._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00033048 File Offset: 0x00031248
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (RectF.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				RectF.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RectF.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return RectF.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0003306C File Offset: 0x0003126C
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			RectF @object = Java.Lang.Object.GetObject<RectF>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00033094 File Offset: 0x00031294
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				RectF._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x040008AB RID: 2219
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/RectF", typeof(RectF));

		// Token: 0x040008AC RID: 2220
		private static Delegate cb_describeContents;

		// Token: 0x040008AD RID: 2221
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
