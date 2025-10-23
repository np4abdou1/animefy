using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store
{
	// Token: 0x02000035 RID: 53
	[Register("com/unity3d/services/store/StoreError", DoNotGenerateAcw = true)]
	public sealed class StoreError : Java.Lang.Enum
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002640 File Offset: 0x00000840
		[Register("CLASS_NOT_FOUND")]
		public static StoreError ClassNotFound
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("CLASS_NOT_FOUND.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002670 File Offset: 0x00000870
		[Register("ILLEGAL_ACCESS")]
		public static StoreError IllegalAccess
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("ILLEGAL_ACCESS.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000026A0 File Offset: 0x000008A0
		[Register("INVOCATION_TARGET")]
		public static StoreError InvocationTarget
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("INVOCATION_TARGET.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000026D0 File Offset: 0x000008D0
		[Register("JSON_ERROR")]
		public static StoreError JsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("JSON_ERROR.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002700 File Offset: 0x00000900
		[Register("NOT_INITIALIZED")]
		public static StoreError NotInitialized
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("NOT_INITIALIZED.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002730 File Offset: 0x00000930
		[Register("NO_SUCH_METHOD")]
		public static StoreError NoSuchMethod
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("NO_SUCH_METHOD.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00002760 File Offset: 0x00000960
		[Register("STORE_ERROR")]
		public static StoreError StoreErrorr
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("STORE_ERROR.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002790 File Offset: 0x00000990
		[Register("UNKNOWN_ERROR")]
		public static StoreError UnknownError
		{
			get
			{
				return Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticFields.GetObjectValue("UNKNOWN_ERROR.Lcom/unity3d/services/store/StoreError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000027C0 File Offset: 0x000009C0
		internal static IntPtr class_ref
		{
			get
			{
				return StoreError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000027E4 File Offset: 0x000009E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreError._members;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000027EC File Offset: 0x000009EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002810 File Offset: 0x00000A10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreError._members.ManagedPeerType;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000256C File Offset: 0x0000076C
		internal StoreError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000281C File Offset: 0x00000A1C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/store/StoreError;", "")]
		public unsafe static StoreError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			StoreError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<StoreError>(StoreError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/store/StoreError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002888 File Offset: 0x00000A88
		[Register("values", "()[Lcom/unity3d/services/store/StoreError;", "")]
		public static StoreError[] Values()
		{
			return (StoreError[])JNIEnv.GetArray(StoreError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/store/StoreError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(StoreError));
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/StoreError", typeof(StoreError));
	}
}
