using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000178 RID: 376
	[Register("com/unity3d/services/core/configuration/PrivacyConfigStatus", DoNotGenerateAcw = true)]
	public sealed class PrivacyConfigStatus : Java.Lang.Enum
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0002D200 File Offset: 0x0002B400
		[Register("ALLOWED")]
		public static PrivacyConfigStatus Allowed
		{
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfigStatus>(PrivacyConfigStatus._members.StaticFields.GetObjectValue("ALLOWED.Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0002D230 File Offset: 0x0002B430
		[Register("DENIED")]
		public static PrivacyConfigStatus Denied
		{
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfigStatus>(PrivacyConfigStatus._members.StaticFields.GetObjectValue("DENIED.Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0002D260 File Offset: 0x0002B460
		[Register("UNKNOWN")]
		public static PrivacyConfigStatus Unknown
		{
			get
			{
				return Java.Lang.Object.GetObject<PrivacyConfigStatus>(PrivacyConfigStatus._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0002D290 File Offset: 0x0002B490
		internal static IntPtr class_ref
		{
			get
			{
				return PrivacyConfigStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0002D2B4 File Offset: 0x0002B4B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PrivacyConfigStatus._members;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0002D2BC File Offset: 0x0002B4BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PrivacyConfigStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0002D2E0 File Offset: 0x0002B4E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PrivacyConfigStatus._members.ManagedPeerType;
			}
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0000256C File Offset: 0x0000076C
		internal PrivacyConfigStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		[Register("toLowerCase", "()Ljava/lang/String;", "")]
		public string ToLowerCase()
		{
			return JNIEnv.GetString(PrivacyConfigStatus._members.InstanceMethods.InvokeAbstractObjectMethod("toLowerCase.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002D320 File Offset: 0x0002B520
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", "")]
		public unsafe static PrivacyConfigStatus ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			PrivacyConfigStatus @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<PrivacyConfigStatus>(PrivacyConfigStatus._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0002D38C File Offset: 0x0002B58C
		[Register("values", "()[Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", "")]
		public static PrivacyConfigStatus[] Values()
		{
			return (PrivacyConfigStatus[])JNIEnv.GetArray(PrivacyConfigStatus._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/configuration/PrivacyConfigStatus;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(PrivacyConfigStatus));
		}

		// Token: 0x04000430 RID: 1072
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/PrivacyConfigStatus", typeof(PrivacyConfigStatus));
	}
}
