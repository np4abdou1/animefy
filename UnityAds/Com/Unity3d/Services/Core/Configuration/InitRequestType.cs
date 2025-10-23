using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000173 RID: 371
	[Register("com/unity3d/services/core/configuration/InitRequestType", DoNotGenerateAcw = true)]
	public sealed class InitRequestType : Java.Lang.Enum
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0002CA34 File Offset: 0x0002AC34
		[Register("PRIVACY")]
		public static InitRequestType Privacy
		{
			get
			{
				return Java.Lang.Object.GetObject<InitRequestType>(InitRequestType._members.StaticFields.GetObjectValue("PRIVACY.Lcom/unity3d/services/core/configuration/InitRequestType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0002CA64 File Offset: 0x0002AC64
		[Register("TOKEN")]
		public static InitRequestType Token
		{
			get
			{
				return Java.Lang.Object.GetObject<InitRequestType>(InitRequestType._members.StaticFields.GetObjectValue("TOKEN.Lcom/unity3d/services/core/configuration/InitRequestType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0002CA94 File Offset: 0x0002AC94
		internal static IntPtr class_ref
		{
			get
			{
				return InitRequestType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0002CAB8 File Offset: 0x0002ACB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitRequestType._members;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitRequestType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitRequestType._members.ManagedPeerType;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0000256C File Offset: 0x0000076C
		internal InitRequestType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
		public string CallType
		{
			[Register("getCallType", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(InitRequestType._members.InstanceMethods.InvokeAbstractObjectMethod("getCallType.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002CB24 File Offset: 0x0002AD24
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/InitRequestType;", "")]
		public unsafe static InitRequestType ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			InitRequestType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<InitRequestType>(InitRequestType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/configuration/InitRequestType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0002CB90 File Offset: 0x0002AD90
		[Register("values", "()[Lcom/unity3d/services/core/configuration/InitRequestType;", "")]
		public static InitRequestType[] Values()
		{
			return (InitRequestType[])JNIEnv.GetArray(InitRequestType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/configuration/InitRequestType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(InitRequestType));
		}

		// Token: 0x04000423 RID: 1059
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/InitRequestType", typeof(InitRequestType));
	}
}
