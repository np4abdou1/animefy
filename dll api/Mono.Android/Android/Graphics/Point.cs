using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x02000228 RID: 552
	[Register("android/graphics/Point", DoNotGenerateAcw = true)]
	public class Point : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00032B3B File Offset: 0x00030D3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Point._members;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x00032B44 File Offset: 0x00030D44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Point._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00032B68 File Offset: 0x00030D68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Point._members.ManagedPeerType;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Point(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00032B74 File Offset: 0x00030D74
		private static Delegate GetDescribeContentsHandler()
		{
			if (Point.cb_describeContents == null)
			{
				Point.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Point.n_DescribeContents));
			}
			return Point.cb_describeContents;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00032B98 File Offset: 0x00030D98
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Point>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00032BA7 File Offset: 0x00030DA7
		public virtual int DescribeContents()
		{
			return Point._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00032BC0 File Offset: 0x00030DC0
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Point.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Point.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Point.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Point.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00032BE4 File Offset: 0x00030DE4
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			Point @object = Java.Lang.Object.GetObject<Point>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00032C0C File Offset: 0x00030E0C
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Point._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x040008A2 RID: 2210
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Point", typeof(Point));

		// Token: 0x040008A3 RID: 2211
		private static Delegate cb_describeContents;

		// Token: 0x040008A4 RID: 2212
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
