using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App.Job
{
	// Token: 0x02000277 RID: 631
	[Register("android/app/job/JobParameters", DoNotGenerateAcw = true)]
	public class JobParameters : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0003E013 File Offset: 0x0003C213
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobParameters._members;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0003E01C File Offset: 0x0003C21C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobParameters._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0003E040 File Offset: 0x0003C240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobParameters._members.ManagedPeerType;
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000021E0 File Offset: 0x000003E0
		protected JobParameters(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0003E04C File Offset: 0x0003C24C
		private static Delegate GetDescribeContentsHandler()
		{
			if (JobParameters.cb_describeContents == null)
			{
				JobParameters.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JobParameters.n_DescribeContents));
			}
			return JobParameters.cb_describeContents;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0003E070 File Offset: 0x0003C270
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JobParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0003E07F File Offset: 0x0003C27F
		public virtual int DescribeContents()
		{
			return JobParameters._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0003E098 File Offset: 0x0003C298
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (JobParameters.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				JobParameters.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(JobParameters.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return JobParameters.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0003E0BC File Offset: 0x0003C2BC
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			JobParameters @object = Java.Lang.Object.GetObject<JobParameters>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0003E0E4 File Offset: 0x0003C2E4
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				JobParameters._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A39 RID: 2617
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/job/JobParameters", typeof(JobParameters));

		// Token: 0x04000A3A RID: 2618
		private static Delegate cb_describeContents;

		// Token: 0x04000A3B RID: 2619
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
