using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Webview.Bridge
{
	// Token: 0x0200007D RID: 125
	[Register("com/unity3d/services/core/webview/bridge/WebViewBridge", DoNotGenerateAcw = true)]
	public class WebViewBridge : Java.Lang.Object
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0000C850 File Offset: 0x0000AA50
		internal static IntPtr class_ref
		{
			get
			{
				return WebViewBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000C874 File Offset: 0x0000AA74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebViewBridge._members;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000C87C File Offset: 0x0000AA7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebViewBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebViewBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebViewBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		[Register(".ctor", "()V", "")]
		public WebViewBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebViewBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebViewBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000C91C File Offset: 0x0000AB1C
		[Register("handleCallback", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe static void HandleCallback(string callbackId, string callbackStatus, Java.Lang.Object[] parameters)
		{
			IntPtr intPtr = JNIEnv.NewString(callbackId);
			IntPtr intPtr2 = JNIEnv.NewString(callbackStatus);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				WebViewBridge._members.StaticMethods.InvokeVoidMethod("handleCallback.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, parameters);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(parameters);
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		[Register("handleInvocation", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void HandleInvocation(string className, string methodName, Java.Lang.Object[] parameters, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(className);
			IntPtr intPtr2 = JNIEnv.NewString(methodName);
			IntPtr intPtr3 = JNIEnv.NewArray<Java.Lang.Object>(parameters);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				WebViewBridge._members.StaticMethods.InvokeVoidMethod("handleInvocation.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (parameters != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr3, parameters);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(parameters);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
		[Register("setClassTable", "([Ljava/lang/Class;)V", "")]
		public unsafe static void SetClassTable(Class[] apiClassList)
		{
			IntPtr intPtr = JNIEnv.NewArray<Class>(apiClassList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebViewBridge._members.StaticMethods.InvokeVoidMethod("setClassTable.([Ljava/lang/Class;)V", ptr);
			}
			finally
			{
				if (apiClassList != null)
				{
					JNIEnv.CopyArray<Class>(intPtr, apiClassList);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(apiClassList);
			}
		}

		// Token: 0x040000EC RID: 236
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/webview/bridge/WebViewBridge", typeof(WebViewBridge));
	}
}
