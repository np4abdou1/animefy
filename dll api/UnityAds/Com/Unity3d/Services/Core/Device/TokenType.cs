using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000126 RID: 294
	[Register("com/unity3d/services/core/device/TokenType", DoNotGenerateAcw = true)]
	public sealed class TokenType : Java.Lang.Enum
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0002136C File Offset: 0x0001F56C
		[Register("TOKEN_NATIVE")]
		public static TokenType TokenNative
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenType>(TokenType._members.StaticFields.GetObjectValue("TOKEN_NATIVE.Lcom/unity3d/services/core/device/TokenType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0002139C File Offset: 0x0001F59C
		[Register("TOKEN_REMOTE")]
		public static TokenType TokenRemote
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenType>(TokenType._members.StaticFields.GetObjectValue("TOKEN_REMOTE.Lcom/unity3d/services/core/device/TokenType;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000213CC File Offset: 0x0001F5CC
		internal static IntPtr class_ref
		{
			get
			{
				return TokenType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000213F0 File Offset: 0x0001F5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TokenType._members;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000213F8 File Offset: 0x0001F5F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TokenType._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002141C File Offset: 0x0001F61C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TokenType._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000256C File Offset: 0x0000076C
		internal TokenType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00021428 File Offset: 0x0001F628
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/TokenType;", "")]
		public unsafe static TokenType ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			TokenType @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TokenType>(TokenType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/TokenType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00021494 File Offset: 0x0001F694
		[Register("values", "()[Lcom/unity3d/services/core/device/TokenType;", "")]
		public static TokenType[] Values()
		{
			return (TokenType[])JNIEnv.GetArray(TokenType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/TokenType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(TokenType));
		}

		// Token: 0x040002AB RID: 683
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/TokenType", typeof(TokenType));
	}
}
