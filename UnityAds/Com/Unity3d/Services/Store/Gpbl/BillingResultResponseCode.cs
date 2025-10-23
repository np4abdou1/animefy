using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store.Gpbl
{
	// Token: 0x02000045 RID: 69
	[Register("com/unity3d/services/store/gpbl/BillingResultResponseCode", DoNotGenerateAcw = true)]
	public sealed class BillingResultResponseCode : Java.Lang.Enum
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00003DC0 File Offset: 0x00001FC0
		[Register("BILLING_UNAVAILABLE")]
		public static BillingResultResponseCode BillingUnavailable
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("BILLING_UNAVAILABLE.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00003DF0 File Offset: 0x00001FF0
		[Register("DEVELOPER_ERROR")]
		public static BillingResultResponseCode DeveloperError
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("DEVELOPER_ERROR.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00003E20 File Offset: 0x00002020
		[Register("ERROR")]
		public static BillingResultResponseCode Error
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("ERROR.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00003E50 File Offset: 0x00002050
		[Register("FEATURE_NOT_SUPPORTED")]
		public static BillingResultResponseCode FeatureNotSupported
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("FEATURE_NOT_SUPPORTED.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00003E80 File Offset: 0x00002080
		[Register("ITEM_ALREADY_OWNED")]
		public static BillingResultResponseCode ItemAlreadyOwned
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("ITEM_ALREADY_OWNED.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00003EB0 File Offset: 0x000020B0
		[Register("ITEM_NOT_OWNED")]
		public static BillingResultResponseCode ItemNotOwned
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("ITEM_NOT_OWNED.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00003EE0 File Offset: 0x000020E0
		[Register("ITEM_UNAVAILABLE")]
		public static BillingResultResponseCode ItemUnavailable
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("ITEM_UNAVAILABLE.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00003F10 File Offset: 0x00002110
		[Register("OK")]
		public static BillingResultResponseCode Ok
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("OK.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00003F40 File Offset: 0x00002140
		[Register("SERVICE_DISCONNECTED")]
		public static BillingResultResponseCode ServiceDisconnected
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("SERVICE_DISCONNECTED.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00003F70 File Offset: 0x00002170
		[Register("SERVICE_TIMEOUT")]
		public static BillingResultResponseCode ServiceTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("SERVICE_TIMEOUT.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00003FA0 File Offset: 0x000021A0
		[Register("SERVICE_UNAVAILABLE")]
		public static BillingResultResponseCode ServiceUnavailable
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("SERVICE_UNAVAILABLE.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00003FD0 File Offset: 0x000021D0
		[Register("USER_CANCELED")]
		public static BillingResultResponseCode UserCanceled
		{
			get
			{
				return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticFields.GetObjectValue("USER_CANCELED.Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00004000 File Offset: 0x00002200
		internal static IntPtr class_ref
		{
			get
			{
				return BillingResultResponseCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00004024 File Offset: 0x00002224
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BillingResultResponseCode._members;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0000402C File Offset: 0x0000222C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BillingResultResponseCode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00004050 File Offset: 0x00002250
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BillingResultResponseCode._members.ManagedPeerType;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000256C File Offset: 0x0000076C
		internal BillingResultResponseCode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000405C File Offset: 0x0000225C
		public int ResponseCode
		{
			[Register("getResponseCode", "()I", "")]
			get
			{
				return BillingResultResponseCode._members.InstanceMethods.InvokeAbstractInt32Method("getResponseCode.()I", this, null);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004078 File Offset: 0x00002278
		[Register("fromResponseCode", "(I)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "")]
		public unsafe static BillingResultResponseCode FromResponseCode(int responseCode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(responseCode);
			return Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticMethods.InvokeObjectMethod("fromResponseCode.(I)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000040C0 File Offset: 0x000022C0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "")]
		public unsafe static BillingResultResponseCode ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			BillingResultResponseCode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BillingResultResponseCode>(BillingResultResponseCode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000412C File Offset: 0x0000232C
		[Register("values", "()[Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", "")]
		public static BillingResultResponseCode[] Values()
		{
			return (BillingResultResponseCode[])JNIEnv.GetArray(BillingResultResponseCode._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/store/gpbl/BillingResultResponseCode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BillingResultResponseCode));
		}

		// Token: 0x04000025 RID: 37
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/BillingResultResponseCode", typeof(BillingResultResponseCode));
	}
}
