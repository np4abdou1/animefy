using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000265 RID: 613
	[Register("android/app/NotificationChannel", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class NotificationChannel : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0003D2D7 File Offset: 0x0003B4D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationChannel._members;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationChannel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0003D304 File Offset: 0x0003B504
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationChannel._members.ManagedPeerType;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000021E0 File Offset: 0x000003E0
		internal NotificationChannel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0003D310 File Offset: 0x0003B510
		public unsafe NotificationChannel(string id, string name, [GeneratedEnum] NotificationImportance importance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((int)importance);
				base.SetHandle(NotificationChannel._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/CharSequence;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationChannel._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/CharSequence;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(name);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0003D3F0 File Offset: 0x0003B5F0
		public unsafe string Description
		{
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					NotificationChannel._members.InstanceMethods.InvokeAbstractVoidMethod("setDescription.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0003D44C File Offset: 0x0003B64C
		public int DescribeContents()
		{
			return NotificationChannel._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0003D468 File Offset: 0x0003B668
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				NotificationChannel._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A0D RID: 2573
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/NotificationChannel", typeof(NotificationChannel));
	}
}
