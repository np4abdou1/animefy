using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader.Pii
{
	// Token: 0x02000145 RID: 325
	[Register("com/unity3d/services/core/device/reader/pii/PiiPrivacyMode", DoNotGenerateAcw = true)]
	public sealed class PiiPrivacyMode : Java.Lang.Enum
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x000247FC File Offset: 0x000229FC
		[Register("APP")]
		public static PiiPrivacyMode App
		{
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticFields.GetObjectValue("APP.Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002482C File Offset: 0x00022A2C
		[Register("MIXED")]
		public static PiiPrivacyMode Mixed
		{
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticFields.GetObjectValue("MIXED.Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002485C File Offset: 0x00022A5C
		[Register("NONE")]
		public static PiiPrivacyMode None
		{
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticFields.GetObjectValue("NONE.Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0002488C File Offset: 0x00022A8C
		[Register("NULL")]
		public static PiiPrivacyMode Null
		{
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticFields.GetObjectValue("NULL.Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x000248BC File Offset: 0x00022ABC
		[Register("UNDEFINED")]
		public static PiiPrivacyMode Undefined
		{
			get
			{
				return Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticFields.GetObjectValue("UNDEFINED.Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000248EC File Offset: 0x00022AEC
		internal static IntPtr class_ref
		{
			get
			{
				return PiiPrivacyMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00024910 File Offset: 0x00022B10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PiiPrivacyMode._members;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00024918 File Offset: 0x00022B18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PiiPrivacyMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0002493C File Offset: 0x00022B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PiiPrivacyMode._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0000256C File Offset: 0x0000076C
		internal PiiPrivacyMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00024948 File Offset: 0x00022B48
		[Register("getPiiPrivacyMode", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", "")]
		public unsafe static PiiPrivacyMode GetPiiPrivacyMode(string privacyModeStr)
		{
			IntPtr intPtr = JNIEnv.NewString(privacyModeStr);
			PiiPrivacyMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticMethods.InvokeObjectMethod("getPiiPrivacyMode.(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000249B4 File Offset: 0x00022BB4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", "")]
		public unsafe static PiiPrivacyMode ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PiiPrivacyMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PiiPrivacyMode>(PiiPrivacyMode._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00024A20 File Offset: 0x00022C20
		[Register("values", "()[Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", "")]
		public static PiiPrivacyMode[] Values()
		{
			return (PiiPrivacyMode[])JNIEnv.GetArray(PiiPrivacyMode._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/reader/pii/PiiPrivacyMode;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PiiPrivacyMode));
		}

		// Token: 0x04000301 RID: 769
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/pii/PiiPrivacyMode", typeof(PiiPrivacyMode));
	}
}
