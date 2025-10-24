using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x0200011C RID: 284
	[Register("com/unity3d/services/core/device/DeviceError", DoNotGenerateAcw = true)]
	public sealed class DeviceError : Java.Lang.Enum
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0001FE54 File Offset: 0x0001E054
		[Register("APPLICATION_CONTEXT_NULL")]
		public static DeviceError ApplicationContextNull
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("APPLICATION_CONTEXT_NULL.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0001FE84 File Offset: 0x0001E084
		[Register("APPLICATION_INFO_NOT_AVAILABLE")]
		public static DeviceError ApplicationInfoNotAvailable
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("APPLICATION_INFO_NOT_AVAILABLE.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		[Register("AUDIOMANAGER_NULL")]
		public static DeviceError AudiomanagerNull
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("AUDIOMANAGER_NULL.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0001FEE4 File Offset: 0x0001E0E4
		[Register("COULDNT_GET_ADB_STATUS")]
		public static DeviceError CouldntGetAdbStatus
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("COULDNT_GET_ADB_STATUS.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0001FF14 File Offset: 0x0001E114
		[Register("COULDNT_GET_DIGEST")]
		public static DeviceError CouldntGetDigest
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("COULDNT_GET_DIGEST.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0001FF44 File Offset: 0x0001E144
		[Register("COULDNT_GET_FINGERPRINT")]
		public static DeviceError CouldntGetFingerprint
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("COULDNT_GET_FINGERPRINT.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0001FF74 File Offset: 0x0001E174
		[Register("COULDNT_GET_GL_VERSION")]
		public static DeviceError CouldntGetGlVersion
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("COULDNT_GET_GL_VERSION.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		[Register("COULDNT_GET_STORAGE_LOCATION")]
		public static DeviceError CouldntGetStorageLocation
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("COULDNT_GET_STORAGE_LOCATION.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		[Register("INVALID_STORAGETYPE")]
		public static DeviceError InvalidStoragetype
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("INVALID_STORAGETYPE.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00020004 File Offset: 0x0001E204
		[Register("JSON_ERROR")]
		public static DeviceError JsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticFields.GetObjectValue("JSON_ERROR.Lcom/unity3d/services/core/device/DeviceError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00020034 File Offset: 0x0001E234
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00020058 File Offset: 0x0001E258
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceError._members;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00020060 File Offset: 0x0001E260
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00020084 File Offset: 0x0001E284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0000256C File Offset: 0x0000076C
		internal DeviceError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00020090 File Offset: 0x0001E290
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/DeviceError;", "")]
		public unsafe static DeviceError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			DeviceError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DeviceError>(DeviceError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/DeviceError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000200FC File Offset: 0x0001E2FC
		[Register("values", "()[Lcom/unity3d/services/core/device/DeviceError;", "")]
		public static DeviceError[] Values()
		{
			return (DeviceError[])JNIEnv.GetArray(DeviceError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/DeviceError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DeviceError));
		}

		// Token: 0x04000291 RID: 657
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/DeviceError", typeof(DeviceError));
	}
}
