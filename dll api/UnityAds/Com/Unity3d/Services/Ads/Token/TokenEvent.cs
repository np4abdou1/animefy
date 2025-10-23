using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001E2 RID: 482
	[Register("com/unity3d/services/ads/token/TokenEvent", DoNotGenerateAcw = true)]
	public sealed class TokenEvent : Java.Lang.Enum
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0003F08C File Offset: 0x0003D28C
		[Register("QUEUE_EMPTY")]
		public static TokenEvent QueueEmpty
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenEvent>(TokenEvent._members.StaticFields.GetObjectValue("QUEUE_EMPTY.Lcom/unity3d/services/ads/token/TokenEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0003F0BC File Offset: 0x0003D2BC
		[Register("TOKEN_ACCESS")]
		public static TokenEvent TokenAccess
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenEvent>(TokenEvent._members.StaticFields.GetObjectValue("TOKEN_ACCESS.Lcom/unity3d/services/ads/token/TokenEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0003F0EC File Offset: 0x0003D2EC
		[Register("TOKEN_NATIVE_DATA")]
		public static TokenEvent TokenNativeData
		{
			get
			{
				return Java.Lang.Object.GetObject<TokenEvent>(TokenEvent._members.StaticFields.GetObjectValue("TOKEN_NATIVE_DATA.Lcom/unity3d/services/ads/token/TokenEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0003F11C File Offset: 0x0003D31C
		internal static IntPtr class_ref
		{
			get
			{
				return TokenEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0003F140 File Offset: 0x0003D340
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TokenEvent._members;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x0003F148 File Offset: 0x0003D348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TokenEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x0003F16C File Offset: 0x0003D36C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TokenEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0000256C File Offset: 0x0000076C
		internal TokenEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0003F178 File Offset: 0x0003D378
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/ads/token/TokenEvent;", "")]
		public unsafe static TokenEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			TokenEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<TokenEvent>(TokenEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/ads/token/TokenEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0003F1E4 File Offset: 0x0003D3E4
		[Register("values", "()[Lcom/unity3d/services/ads/token/TokenEvent;", "")]
		public static TokenEvent[] Values()
		{
			return (TokenEvent[])JNIEnv.GetArray(TokenEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/ads/token/TokenEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(TokenEvent));
		}

		// Token: 0x04000536 RID: 1334
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/TokenEvent", typeof(TokenEvent));
	}
}
