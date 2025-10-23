using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000021 RID: 33
	[Register("com/google/android/gms/common/api/Status", DoNotGenerateAcw = true)]
	public sealed class Statuses : Java.Lang.Object
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(Statuses._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[Register("RESULT_CANCELED")]
		public static Statuses ResultCanceled
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_CANCELED.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003B04 File Offset: 0x00001D04
		[Register("RESULT_DEAD_CLIENT")]
		public static Statuses ResultDeadClient
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_DEAD_CLIENT.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003B34 File Offset: 0x00001D34
		[Register("RESULT_INTERNAL_ERROR")]
		public static Statuses ResultInternalError
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_INTERNAL_ERROR.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003B64 File Offset: 0x00001D64
		[Register("RESULT_INTERRUPTED")]
		public static Statuses ResultInterrupted
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_INTERRUPTED.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003B94 File Offset: 0x00001D94
		[Register("RESULT_SUCCESS")]
		public static Statuses ResultSuccess
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_SUCCESS.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00003BC4 File Offset: 0x00001DC4
		[Register("RESULT_SUCCESS_CACHE")]
		public static Statuses ResultSuccessCache
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_SUCCESS_CACHE.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003BF4 File Offset: 0x00001DF4
		[Register("RESULT_TIMEOUT")]
		public static Statuses ResultTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.StaticFields.GetObjectValue("RESULT_TIMEOUT.Lcom/google/android/gms/common/api/Status;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00003C24 File Offset: 0x00001E24
		internal static IntPtr class_ref
		{
			get
			{
				return Statuses._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003C48 File Offset: 0x00001E48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Statuses._members;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003C50 File Offset: 0x00001E50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Statuses._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003C74 File Offset: 0x00001E74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Statuses._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002EC0 File Offset: 0x000010C0
		internal Statuses(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00003C80 File Offset: 0x00001E80
		[Register(".ctor", "(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;)V", "")]
		public unsafe Statuses(ConnectionResult connectionResult, string statusMessage) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(statusMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((connectionResult == null) ? IntPtr.Zero : connectionResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(Statuses._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Statuses._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(connectionResult);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00003D4C File Offset: 0x00001F4C
		[Register(".ctor", "(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;I)V", "")]
		public unsafe Statuses(ConnectionResult connectionResult, string statusMessage, int statusCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(statusMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((connectionResult == null) ? IntPtr.Zero : connectionResult.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(statusCode);
				base.SetHandle(Statuses._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Statuses._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/ConnectionResult;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(connectionResult);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00003E30 File Offset: 0x00002030
		[Register(".ctor", "(I)V", "")]
		public unsafe Statuses(int statusCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(statusCode);
			base.SetHandle(Statuses._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Statuses._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Register(".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe Statuses(int statusCode, string statusMessage) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(statusMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(statusCode);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(Statuses._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Statuses._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003F6C File Offset: 0x0000216C
		[Register(".ctor", "(ILjava/lang/String;Landroid/app/PendingIntent;)V", "")]
		public unsafe Statuses(int statusCode, string statusMessage, PendingIntent pendingIntent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(statusMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(statusCode);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((pendingIntent == null) ? IntPtr.Zero : pendingIntent.Handle);
				base.SetHandle(Statuses._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Landroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Statuses._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Landroid/app/PendingIntent;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(pendingIntent);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00004050 File Offset: 0x00002250
		public ConnectionResult ConnectionResult
		{
			[Register("getConnectionResult", "()Lcom/google/android/gms/common/ConnectionResult;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ConnectionResult>(Statuses._members.InstanceMethods.InvokeAbstractObjectMethod("getConnectionResult.()Lcom/google/android/gms/common/ConnectionResult;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00004082 File Offset: 0x00002282
		public bool HasResolution
		{
			[Register("hasResolution", "()Z", "")]
			get
			{
				return Statuses._members.InstanceMethods.InvokeAbstractBooleanMethod("hasResolution.()Z", this, null);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000409B File Offset: 0x0000229B
		public bool IsCanceled
		{
			[Register("isCanceled", "()Z", "")]
			get
			{
				return Statuses._members.InstanceMethods.InvokeAbstractBooleanMethod("isCanceled.()Z", this, null);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000040B4 File Offset: 0x000022B4
		public bool IsInterrupted
		{
			[Register("isInterrupted", "()Z", "")]
			get
			{
				return Statuses._members.InstanceMethods.InvokeAbstractBooleanMethod("isInterrupted.()Z", this, null);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000040CD File Offset: 0x000022CD
		public bool IsSuccess
		{
			[Register("isSuccess", "()Z", "")]
			get
			{
				return Statuses._members.InstanceMethods.InvokeAbstractBooleanMethod("isSuccess.()Z", this, null);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000040E8 File Offset: 0x000022E8
		public PendingIntent Resolution
		{
			[Register("getResolution", "()Landroid/app/PendingIntent;", "")]
			get
			{
				return Java.Lang.Object.GetObject<PendingIntent>(Statuses._members.InstanceMethods.InvokeAbstractObjectMethod("getResolution.()Landroid/app/PendingIntent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000411C File Offset: 0x0000231C
		public Statuses Status
		{
			[Register("getStatus", "()Lcom/google/android/gms/common/api/Status;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Statuses>(Statuses._members.InstanceMethods.InvokeAbstractObjectMethod("getStatus.()Lcom/google/android/gms/common/api/Status;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000414E File Offset: 0x0000234E
		public int StatusCode
		{
			[Register("getStatusCode", "()I", "")]
			get
			{
				return Statuses._members.InstanceMethods.InvokeAbstractInt32Method("getStatusCode.()I", this, null);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00004168 File Offset: 0x00002368
		public string StatusMessage
		{
			[Register("getStatusMessage", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Statuses._members.InstanceMethods.InvokeAbstractObjectMethod("getStatusMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000419C File Offset: 0x0000239C
		[Register("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public unsafe void StartResolutionForResult(Activity activity, int requestCode)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(requestCode);
				Statuses._members.InstanceMethods.InvokeAbstractVoidMethod("startResolutionForResult.(Landroid/app/Activity;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004214 File Offset: 0x00002414
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel(Parcel @out, int flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue(flags);
				Statuses._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Status", typeof(Statuses));
	}
}
