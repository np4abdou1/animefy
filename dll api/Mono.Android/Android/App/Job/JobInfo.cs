using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App.Job
{
	// Token: 0x02000275 RID: 629
	[Register("android/app/job/JobInfo", DoNotGenerateAcw = true)]
	public class JobInfo : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0003DE5B File Offset: 0x0003C05B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobInfo._members;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0003DE64 File Offset: 0x0003C064
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0003DE88 File Offset: 0x0003C088
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000021E0 File Offset: 0x000003E0
		protected JobInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0003DE94 File Offset: 0x0003C094
		private static Delegate GetDescribeContentsHandler()
		{
			if (JobInfo.cb_describeContents == null)
			{
				JobInfo.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(JobInfo.n_DescribeContents));
			}
			return JobInfo.cb_describeContents;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<JobInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0003DEC7 File Offset: 0x0003C0C7
		public virtual int DescribeContents()
		{
			return JobInfo._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (JobInfo.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				JobInfo.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(JobInfo.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return JobInfo.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0003DF04 File Offset: 0x0003C104
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			JobInfo @object = Java.Lang.Object.GetObject<JobInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0003DF2C File Offset: 0x0003C12C
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				JobInfo._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000A35 RID: 2613
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/job/JobInfo", typeof(JobInfo));

		// Token: 0x04000A36 RID: 2614
		private static Delegate cb_describeContents;

		// Token: 0x04000A37 RID: 2615
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x02000276 RID: 630
		[Register("android/app/job/JobInfo$Builder", DoNotGenerateAcw = true)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000519 RID: 1305
			// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0003DFBF File Offset: 0x0003C1BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return JobInfo.Builder._members;
				}
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0003DFC8 File Offset: 0x0003C1C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return JobInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700051B RID: 1307
			// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0003DFEC File Offset: 0x0003C1EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return JobInfo.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060017EA RID: 6122 RVA: 0x000021E0 File Offset: 0x000003E0
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000A38 RID: 2616
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/job/JobInfo$Builder", typeof(JobInfo.Builder));
		}
	}
}
