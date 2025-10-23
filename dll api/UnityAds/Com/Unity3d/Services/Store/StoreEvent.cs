using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store
{
	// Token: 0x02000036 RID: 54
	[Register("com/unity3d/services/store/StoreEvent", DoNotGenerateAcw = true)]
	public sealed class StoreEvent : Java.Lang.Enum
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000028E4 File Offset: 0x00000AE4
		[Register("DISCONNECTED_RESULT")]
		public static StoreEvent DisconnectedResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("DISCONNECTED_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002914 File Offset: 0x00000B14
		[Register("INITIALIZATION_REQUEST_FAILED")]
		public static StoreEvent InitializationRequestFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("INITIALIZATION_REQUEST_FAILED.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002944 File Offset: 0x00000B44
		[Register("INITIALIZATION_REQUEST_RESULT")]
		public static StoreEvent InitializationRequestResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("INITIALIZATION_REQUEST_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002974 File Offset: 0x00000B74
		[Register("IS_FEATURE_SUPPORTED_REQUEST_ERROR")]
		public static StoreEvent IsFeatureSupportedRequestError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("IS_FEATURE_SUPPORTED_REQUEST_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000029A4 File Offset: 0x00000BA4
		[Register("IS_FEATURE_SUPPORTED_REQUEST_RESULT")]
		public static StoreEvent IsFeatureSupportedRequestResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("IS_FEATURE_SUPPORTED_REQUEST_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000029D4 File Offset: 0x00000BD4
		[Register("PURCHASES_ON_RESUME_ERROR")]
		public static StoreEvent PurchasesOnResumeError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_ON_RESUME_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002A04 File Offset: 0x00000C04
		[Register("PURCHASES_ON_RESUME_RESULT")]
		public static StoreEvent PurchasesOnResumeResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_ON_RESUME_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002A34 File Offset: 0x00000C34
		[Register("PURCHASES_REQUEST_ERROR")]
		public static StoreEvent PurchasesRequestError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_REQUEST_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002A64 File Offset: 0x00000C64
		[Register("PURCHASES_REQUEST_RESULT")]
		public static StoreEvent PurchasesRequestResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_REQUEST_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002A94 File Offset: 0x00000C94
		[Register("PURCHASES_UPDATED_ERROR")]
		public static StoreEvent PurchasesUpdatedError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_UPDATED_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002AC4 File Offset: 0x00000CC4
		[Register("PURCHASES_UPDATED_RESULT")]
		public static StoreEvent PurchasesUpdatedResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASES_UPDATED_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002AF4 File Offset: 0x00000CF4
		[Register("PURCHASE_HISTORY_LIST_REQUEST_ERROR")]
		public static StoreEvent PurchaseHistoryListRequestError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASE_HISTORY_LIST_REQUEST_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002B24 File Offset: 0x00000D24
		[Register("PURCHASE_HISTORY_LIST_REQUEST_RESULT")]
		public static StoreEvent PurchaseHistoryListRequestResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("PURCHASE_HISTORY_LIST_REQUEST_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002B54 File Offset: 0x00000D54
		[Register("SKU_DETAILS_LIST_REQUEST_ERROR")]
		public static StoreEvent SkuDetailsListRequestError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("SKU_DETAILS_LIST_REQUEST_ERROR.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002B84 File Offset: 0x00000D84
		[Register("SKU_DETAILS_LIST_REQUEST_RESULT")]
		public static StoreEvent SkuDetailsListRequestResult
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticFields.GetObjectValue("SKU_DETAILS_LIST_REQUEST_RESULT.Lcom/unity3d/services/store/StoreEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002BB4 File Offset: 0x00000DB4
		internal static IntPtr class_ref
		{
			get
			{
				return StoreEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002BD8 File Offset: 0x00000DD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreEvent._members;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002C04 File Offset: 0x00000E04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000256C File Offset: 0x0000076C
		internal StoreEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002C10 File Offset: 0x00000E10
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/store/StoreEvent;", "")]
		public unsafe static StoreEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			StoreEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StoreEvent>(StoreEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/store/StoreEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002C7C File Offset: 0x00000E7C
		[Register("values", "()[Lcom/unity3d/services/store/StoreEvent;", "")]
		public static StoreEvent[] Values()
		{
			return (StoreEvent[])JNIEnv.GetArray(StoreEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/store/StoreEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(StoreEvent));
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/StoreEvent", typeof(StoreEvent));
	}
}
