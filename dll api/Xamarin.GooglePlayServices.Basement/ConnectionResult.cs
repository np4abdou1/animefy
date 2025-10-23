using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Gms.Common.Internal.SafeParcel;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/gms/common/ConnectionResult", DoNotGenerateAcw = true)]
	public sealed class ConnectionResult : AbstractSafeParcelable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(ConnectionResult._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002080 File Offset: 0x00000280
		[Register("RESULT_SUCCESS")]
		public static ConnectionResult ResultSuccess
		{
			get
			{
				return Java.Lang.Object.GetObject<ConnectionResult>(ConnectionResult._members.StaticFields.GetObjectValue("RESULT_SUCCESS.Lcom/google/android/gms/common/ConnectionResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000020B0 File Offset: 0x000002B0
		internal new static IntPtr class_ref
		{
			get
			{
				return ConnectionResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000020D4 File Offset: 0x000002D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectionResult._members;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000020DC File Offset: 0x000002DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectionResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002100 File Offset: 0x00000300
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectionResult._members.ManagedPeerType;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000210C File Offset: 0x0000030C
		internal ConnectionResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002118 File Offset: 0x00000318
		[Register(".ctor", "(I)V", "")]
		public unsafe ConnectionResult(int statusCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(statusCode);
			base.SetHandle(ConnectionResult._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ConnectionResult._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000219C File Offset: 0x0000039C
		[Register(".ctor", "(ILandroid/app/PendingIntent;)V", "")]
		public unsafe ConnectionResult(int statusCode, PendingIntent pendingIntent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(statusCode);
				ptr[1] = new JniArgumentValue((pendingIntent == null) ? IntPtr.Zero : pendingIntent.Handle);
				base.SetHandle(ConnectionResult._members.InstanceMethods.StartCreateInstance("(ILandroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConnectionResult._members.InstanceMethods.FinishCreateInstance("(ILandroid/app/PendingIntent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(pendingIntent);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000225C File Offset: 0x0000045C
		[Register(".ctor", "(ILandroid/app/PendingIntent;Ljava/lang/String;)V", "")]
		public unsafe ConnectionResult(int statusCode, PendingIntent pendingIntent, string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(statusCode);
				ptr[1] = new JniArgumentValue((pendingIntent == null) ? IntPtr.Zero : pendingIntent.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				base.SetHandle(ConnectionResult._members.InstanceMethods.StartCreateInstance("(ILandroid/app/PendingIntent;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ConnectionResult._members.InstanceMethods.FinishCreateInstance("(ILandroid/app/PendingIntent;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(pendingIntent);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002340 File Offset: 0x00000540
		public int ErrorCode
		{
			[Register("getErrorCode", "()I", "")]
			get
			{
				return ConnectionResult._members.InstanceMethods.InvokeAbstractInt32Method("getErrorCode.()I", this, null);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000235C File Offset: 0x0000055C
		public string ErrorMessage
		{
			[Register("getErrorMessage", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ConnectionResult._members.InstanceMethods.InvokeAbstractObjectMethod("getErrorMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000238E File Offset: 0x0000058E
		public bool HasResolution
		{
			[Register("hasResolution", "()Z", "")]
			get
			{
				return ConnectionResult._members.InstanceMethods.InvokeAbstractBooleanMethod("hasResolution.()Z", this, null);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000023A7 File Offset: 0x000005A7
		public bool IsSuccess
		{
			[Register("isSuccess", "()Z", "")]
			get
			{
				return ConnectionResult._members.InstanceMethods.InvokeAbstractBooleanMethod("isSuccess.()Z", this, null);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000023C0 File Offset: 0x000005C0
		public PendingIntent Resolution
		{
			[Register("getResolution", "()Landroid/app/PendingIntent;", "")]
			get
			{
				return Java.Lang.Object.GetObject<PendingIntent>(ConnectionResult._members.InstanceMethods.InvokeAbstractObjectMethod("getResolution.()Landroid/app/PendingIntent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000023F4 File Offset: 0x000005F4
		[Register("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public unsafe void StartResolutionForResult(Activity activity, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				ConnectionResult._members.InstanceMethods.InvokeAbstractVoidMethod("startResolutionForResult.(Landroid/app/Activity;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000246C File Offset: 0x0000066C
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ConnectionResult._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/ConnectionResult", typeof(ConnectionResult));
	}
}
