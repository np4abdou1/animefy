using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000225 RID: 549
	[Register("com/unity3d/services/ads/api/Token", DoNotGenerateAcw = true)]
	public class Token : Java.Lang.Object
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x0004B6C4 File Offset: 0x000498C4
		internal static IntPtr class_ref
		{
			get
			{
				return Token._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0004B6E8 File Offset: 0x000498E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Token._members;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0004B6F0 File Offset: 0x000498F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Token._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0004B714 File Offset: 0x00049914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Token._members.ManagedPeerType;
			}
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Token(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0004B720 File Offset: 0x00049920
		[Register(".ctor", "()V", "")]
		public Token() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Token._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Token._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0004B790 File Offset: 0x00049990
		[Register("appendTokens", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void AppendTokens(JSONArray tokens, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tokens == null) ? IntPtr.Zero : tokens.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Token._members.StaticMethods.InvokeVoidMethod("appendTokens.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(tokens);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0004B81C File Offset: 0x00049A1C
		[Register("createTokens", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void CreateTokens(JSONArray tokens, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tokens == null) ? IntPtr.Zero : tokens.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Token._members.StaticMethods.InvokeVoidMethod("createTokens.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(tokens);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		[Register("deleteTokens", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void DeleteTokens(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Token._members.StaticMethods.InvokeVoidMethod("deleteTokens.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0004B90C File Offset: 0x00049B0C
		[Register("getNativeGeneratedToken", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNativeGeneratedToken(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Token._members.StaticMethods.InvokeVoidMethod("getNativeGeneratedToken.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0004B970 File Offset: 0x00049B70
		[Register("setPeekMode", "(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetPeekMode(Java.Lang.Boolean mode, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((mode == null) ? IntPtr.Zero : mode.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Token._members.StaticMethods.InvokeVoidMethod("setPeekMode.(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(mode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400065C RID: 1628
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/Token", typeof(Token));
	}
}
