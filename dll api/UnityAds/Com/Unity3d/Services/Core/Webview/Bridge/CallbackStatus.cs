using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x02000072 RID: 114
	[Register("com/unity3d/services/core/webview/bridge/CallbackStatus", DoNotGenerateAcw = true)]
	public sealed class CallbackStatus : Java.Lang.Enum
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000B4E4 File Offset: 0x000096E4
		[Register("ERROR")]
		public static CallbackStatus Error
		{
			get
			{
				return Java.Lang.Object.GetObject<CallbackStatus>(CallbackStatus._members.StaticFields.GetObjectValue("ERROR.Lcom/unity3d/services/core/webview/bridge/CallbackStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000B514 File Offset: 0x00009714
		[Register("OK")]
		public static CallbackStatus Ok
		{
			get
			{
				return Java.Lang.Object.GetObject<CallbackStatus>(CallbackStatus._members.StaticFields.GetObjectValue("OK.Lcom/unity3d/services/core/webview/bridge/CallbackStatus;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000B544 File Offset: 0x00009744
		internal static IntPtr class_ref
		{
			get
			{
				return CallbackStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000B568 File Offset: 0x00009768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CallbackStatus._members;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0000B570 File Offset: 0x00009770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CallbackStatus._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000B594 File Offset: 0x00009794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CallbackStatus._members.ManagedPeerType;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000256C File Offset: 0x0000076C
		internal CallbackStatus(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000B5A0 File Offset: 0x000097A0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/CallbackStatus;", "")]
		public unsafe static CallbackStatus ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			CallbackStatus @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CallbackStatus>(CallbackStatus._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/webview/bridge/CallbackStatus;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000B60C File Offset: 0x0000980C
		[Register("values", "()[Lcom/unity3d/services/core/webview/bridge/CallbackStatus;", "")]
		public static CallbackStatus[] Values()
		{
			return (CallbackStatus[])JNIEnv.GetArray(CallbackStatus._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/webview/bridge/CallbackStatus;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(CallbackStatus));
		}

		// Token: 0x040000C7 RID: 199
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/CallbackStatus", typeof(CallbackStatus));
	}
}
