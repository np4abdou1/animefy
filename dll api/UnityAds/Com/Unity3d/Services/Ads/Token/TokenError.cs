using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001E1 RID: 481
	[Register("com/unity3d/services/ads/token/TokenError", DoNotGenerateAcw = true)]
	public sealed class TokenError : Java.Lang.Enum
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0003EF38 File Offset: 0x0003D138
		[Register("JSON_EXCEPTION")]
		public static TokenError JsonException
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenError>(TokenError._members.StaticFields.GetObjectValue("JSON_EXCEPTION.Lcom/unity3d/services/ads/token/TokenError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x0003EF68 File Offset: 0x0003D168
		internal static IntPtr class_ref
		{
			get
			{
				return TokenError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0003EF8C File Offset: 0x0003D18C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TokenError._members;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0003EF94 File Offset: 0x0003D194
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TokenError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TokenError._members.ManagedPeerType;
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0000256C File Offset: 0x0000076C
		internal TokenError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/token/TokenError;", "")]
		public unsafe static TokenError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			TokenError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TokenError>(TokenError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/token/TokenError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0003F030 File Offset: 0x0003D230
		[Register("values", "()[Lcom/unity3d/services/ads/token/TokenError;", "")]
		public static TokenError[] Values()
		{
			return (TokenError[])JNIEnv.GetArray(TokenError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/token/TokenError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(TokenError));
		}

		// Token: 0x04000535 RID: 1333
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/TokenError", typeof(TokenError));
	}
}
