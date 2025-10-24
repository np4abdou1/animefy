using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000122 RID: 290
	[Register("com/unity3d/services/core/device/StorageError", DoNotGenerateAcw = true)]
	public sealed class StorageError : Java.Lang.Enum
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000209F0 File Offset: 0x0001EBF0
		[Register("COULDNT_CLEAR_STORAGE")]
		public static StorageError CouldntClearStorage
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_CLEAR_STORAGE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00020A20 File Offset: 0x0001EC20
		[Register("COULDNT_DELETE_VALUE")]
		public static StorageError CouldntDeleteValue
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_DELETE_VALUE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00020A50 File Offset: 0x0001EC50
		[Register("COULDNT_GET_STORAGE")]
		public static StorageError CouldntGetStorage
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_GET_STORAGE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00020A80 File Offset: 0x0001EC80
		[Register("COULDNT_GET_VALUE")]
		public static StorageError CouldntGetValue
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_GET_VALUE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		[Register("COULDNT_SET_VALUE")]
		public static StorageError CouldntSetValue
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_SET_VALUE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		[Register("COULDNT_WRITE_STORAGE_TO_CACHE")]
		public static StorageError CouldntWriteStorageToCache
		{
			get
			{
				return Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticFields.GetObjectValue("COULDNT_WRITE_STORAGE_TO_CACHE.Lcom/unity3d/services/core/device/StorageError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00020B10 File Offset: 0x0001ED10
		internal static IntPtr class_ref
		{
			get
			{
				return StorageError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00020B34 File Offset: 0x0001ED34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StorageError._members;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00020B3C File Offset: 0x0001ED3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StorageError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00020B60 File Offset: 0x0001ED60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StorageError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0000256C File Offset: 0x0000076C
		internal StorageError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00020B6C File Offset: 0x0001ED6C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageError;", "")]
		public unsafe static StorageError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			StorageError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StorageError>(StorageError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00020BD8 File Offset: 0x0001EDD8
		[Register("values", "()[Lcom/unity3d/services/core/device/StorageError;", "")]
		public static StorageError[] Values()
		{
			return (StorageError[])JNIEnv.GetArray(StorageError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/StorageError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(StorageError));
		}

		// Token: 0x040002A7 RID: 679
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/StorageError", typeof(StorageError));
	}
}
