using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000141 RID: 321
	[Register("com/unity3d/services/core/device/reader/pii/DataSelectorResult", DoNotGenerateAcw = true)]
	public sealed class DataSelectorResult : Java.Lang.Enum
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00023F18 File Offset: 0x00022118
		[Register("EXCLUDE")]
		public static DataSelectorResult Exclude
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSelectorResult>(DataSelectorResult._members.StaticFields.GetObjectValue("EXCLUDE.Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00023F48 File Offset: 0x00022148
		[Register("INCLUDE")]
		public static DataSelectorResult Include
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSelectorResult>(DataSelectorResult._members.StaticFields.GetObjectValue("INCLUDE.Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00023F78 File Offset: 0x00022178
		[Register("UPDATE")]
		public static DataSelectorResult Update
		{
			get
			{
				return Java.Lang.Object.GetObject<DataSelectorResult>(DataSelectorResult._members.StaticFields.GetObjectValue("UPDATE.Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00023FA8 File Offset: 0x000221A8
		internal static IntPtr class_ref
		{
			get
			{
				return DataSelectorResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00023FCC File Offset: 0x000221CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataSelectorResult._members;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00023FD4 File Offset: 0x000221D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DataSelectorResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00023FF8 File Offset: 0x000221F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataSelectorResult._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0000256C File Offset: 0x0000076C
		internal DataSelectorResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00024004 File Offset: 0x00022204
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", "")]
		public unsafe static DataSelectorResult ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			DataSelectorResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DataSelectorResult>(DataSelectorResult._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00024070 File Offset: 0x00022270
		[Register("values", "()[Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", "")]
		public static DataSelectorResult[] Values()
		{
			return (DataSelectorResult[])JNIEnv.GetArray(DataSelectorResult._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/reader/pii/DataSelectorResult;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DataSelectorResult));
		}

		// Token: 0x040002F7 RID: 759
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/DataSelectorResult", typeof(DataSelectorResult));
	}
}
