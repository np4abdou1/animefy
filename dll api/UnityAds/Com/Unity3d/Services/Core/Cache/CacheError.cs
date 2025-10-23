using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Cache
{
	// Token: 0x0200017D RID: 381
	[Register("com/unity3d/services/core/cache/CacheError", DoNotGenerateAcw = true)]
	public sealed class CacheError : Java.Lang.Enum
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0002DE60 File Offset: 0x0002C060
		[Register("CACHE_DIRECTORY_DOESNT_EXIST")]
		public static CacheError CacheDirectoryDoesntExist
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("CACHE_DIRECTORY_DOESNT_EXIST.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0002DE90 File Offset: 0x0002C090
		[Register("CACHE_DIRECTORY_EXISTS")]
		public static CacheError CacheDirectoryExists
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("CACHE_DIRECTORY_EXISTS.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		[Register("CACHE_DIRECTORY_NULL")]
		public static CacheError CacheDirectoryNull
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("CACHE_DIRECTORY_NULL.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		[Register("CACHE_DIRECTORY_TYPE_NULL")]
		public static CacheError CacheDirectoryTypeNull
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("CACHE_DIRECTORY_TYPE_NULL.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0002DF20 File Offset: 0x0002C120
		[Register("FILE_ALREADY_CACHING")]
		public static CacheError FileAlreadyCaching
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("FILE_ALREADY_CACHING.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0002DF50 File Offset: 0x0002C150
		[Register("FILE_IO_ERROR")]
		public static CacheError FileIoError
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("FILE_IO_ERROR.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0002DF80 File Offset: 0x0002C180
		[Register("FILE_NOT_FOUND")]
		public static CacheError FileNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("FILE_NOT_FOUND.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		[Register("FILE_STATE_WRONG")]
		public static CacheError FileStateWrong
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("FILE_STATE_WRONG.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		[Register("ILLEGAL_STATE")]
		public static CacheError IllegalState
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("ILLEGAL_STATE.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0002E010 File Offset: 0x0002C210
		[Register("INVALID_ARGUMENT")]
		public static CacheError InvalidArgument
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("INVALID_ARGUMENT.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x0002E040 File Offset: 0x0002C240
		[Register("JSON_ERROR")]
		public static CacheError JsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("JSON_ERROR.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0002E070 File Offset: 0x0002C270
		[Register("MALFORMED_URL")]
		public static CacheError MalformedUrl
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("MALFORMED_URL.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x0002E0A0 File Offset: 0x0002C2A0
		[Register("NETWORK_ERROR")]
		public static CacheError NetworkError
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("NETWORK_ERROR.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		[Register("NOT_CACHING")]
		public static CacheError NotCaching
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("NOT_CACHING.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0002E100 File Offset: 0x0002C300
		[Register("NO_INTERNET")]
		public static CacheError NoInternet
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("NO_INTERNET.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0002E130 File Offset: 0x0002C330
		[Register("UNKNOWN_ERROR")]
		public static CacheError UnknownError
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("UNKNOWN_ERROR.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0002E160 File Offset: 0x0002C360
		[Register("UNSUPPORTED_ENCODING")]
		public static CacheError UnsupportedEncoding
		{
			get
			{
				return Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticFields.GetObjectValue("UNSUPPORTED_ENCODING.Lcom/unity3d/services/core/cache/CacheError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0002E190 File Offset: 0x0002C390
		internal static IntPtr class_ref
		{
			get
			{
				return CacheError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CacheError._members;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CacheError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x0002E1E0 File Offset: 0x0002C3E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CacheError._members.ManagedPeerType;
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0000256C File Offset: 0x0000076C
		internal CacheError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0002E1EC File Offset: 0x0002C3EC
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheError;", "")]
		public unsafe static CacheError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			CacheError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CacheError>(CacheError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/cache/CacheError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0002E258 File Offset: 0x0002C458
		[Register("values", "()[Lcom/unity3d/services/core/cache/CacheError;", "")]
		public static CacheError[] Values()
		{
			return (CacheError[])JNIEnv.GetArray(CacheError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/cache/CacheError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CacheError));
		}

		// Token: 0x0400043E RID: 1086
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/cache/CacheError", typeof(CacheError));
	}
}
