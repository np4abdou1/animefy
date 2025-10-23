using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001E3 RID: 483
	[Register("com/unity3d/services/ads/token/TokenStorage", DoNotGenerateAcw = true)]
	public class TokenStorage : Java.Lang.Object
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0003F240 File Offset: 0x0003D440
		internal static IntPtr class_ref
		{
			get
			{
				return TokenStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0003F264 File Offset: 0x0003D464
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TokenStorage._members;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x0003F26C File Offset: 0x0003D46C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TokenStorage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0003F290 File Offset: 0x0003D490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TokenStorage._members.ManagedPeerType;
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000021E8 File Offset: 0x000003E8
		protected TokenStorage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0003F29C File Offset: 0x0003D49C
		[Register(".ctor", "()V", "")]
		public TokenStorage() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TokenStorage._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TokenStorage._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0003F30C File Offset: 0x0003D50C
		public static string Token
		{
			[Register("getToken", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(TokenStorage._members.StaticMethods.InvokeObjectMethod("getToken.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0003F340 File Offset: 0x0003D540
		[Register("appendTokens", "(Lorg/json/JSONArray;)V", "")]
		public unsafe static void AppendTokens(JSONArray tokens)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tokens == null) ? IntPtr.Zero : tokens.Handle);
				TokenStorage._members.StaticMethods.InvokeVoidMethod("appendTokens.(Lorg/json/JSONArray;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(tokens);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0003F3A4 File Offset: 0x0003D5A4
		[Register("createTokens", "(Lorg/json/JSONArray;)V", "")]
		public unsafe static void CreateTokens(JSONArray tokens)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tokens == null) ? IntPtr.Zero : tokens.Handle);
				TokenStorage._members.StaticMethods.InvokeVoidMethod("createTokens.(Lorg/json/JSONArray;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(tokens);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x0003F408 File Offset: 0x0003D608
		[Register("deleteTokens", "()V", "")]
		public static void DeleteTokens()
		{
			TokenStorage._members.StaticMethods.InvokeVoidMethod("deleteTokens.()V", null);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x0003F420 File Offset: 0x0003D620
		[Register("getNativeGeneratedToken", "()V", "")]
		public static void GetNativeGeneratedToken()
		{
			TokenStorage._members.StaticMethods.InvokeVoidMethod("getNativeGeneratedToken.()V", null);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0003F438 File Offset: 0x0003D638
		[Register("setInitToken", "(Ljava/lang/String;)V", "")]
		public unsafe static void SetInitToken(string value)
		{
			IntPtr intPtr = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				TokenStorage._members.StaticMethods.InvokeVoidMethod("setInitToken.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0003F494 File Offset: 0x0003D694
		[Register("setPeekMode", "(Z)V", "")]
		public unsafe static void SetPeekMode(bool mode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(mode);
			TokenStorage._members.StaticMethods.InvokeVoidMethod("setPeekMode.(Z)V", ptr);
		}

		// Token: 0x04000537 RID: 1335
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/TokenStorage", typeof(TokenStorage));
	}
}
