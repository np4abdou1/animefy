using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Service.Notification
{
	// Token: 0x020001D6 RID: 470
	[Register("android/service/notification/StatusBarNotification", DoNotGenerateAcw = true)]
	public class StatusBarNotification : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0002D5C7 File Offset: 0x0002B7C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StatusBarNotification._members;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StatusBarNotification._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0002D5F4 File Offset: 0x0002B7F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StatusBarNotification._members.ManagedPeerType;
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000021E0 File Offset: 0x000003E0
		protected StatusBarNotification(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0002D600 File Offset: 0x0002B800
		private static Delegate GetDescribeContentsHandler()
		{
			if (StatusBarNotification.cb_describeContents == null)
			{
				StatusBarNotification.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StatusBarNotification.n_DescribeContents));
			}
			return StatusBarNotification.cb_describeContents;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0002D624 File Offset: 0x0002B824
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StatusBarNotification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0002D633 File Offset: 0x0002B833
		public virtual int DescribeContents()
		{
			return StatusBarNotification._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0002D64C File Offset: 0x0002B84C
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (StatusBarNotification.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				StatusBarNotification.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(StatusBarNotification.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return StatusBarNotification.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0002D670 File Offset: 0x0002B870
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			StatusBarNotification @object = Java.Lang.Object.GetObject<StatusBarNotification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0002D698 File Offset: 0x0002B898
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				StatusBarNotification._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x040007C3 RID: 1987
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/service/notification/StatusBarNotification", typeof(StatusBarNotification));

		// Token: 0x040007C4 RID: 1988
		private static Delegate cb_describeContents;

		// Token: 0x040007C5 RID: 1989
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
