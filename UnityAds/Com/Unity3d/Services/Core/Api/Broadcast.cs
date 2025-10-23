using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000184 RID: 388
	[Register("com/unity3d/services/core/api/Broadcast", DoNotGenerateAcw = true)]
	public class Broadcast : Java.Lang.Object
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0002EE44 File Offset: 0x0002D044
		internal static IntPtr class_ref
		{
			get
			{
				return Broadcast._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0002EE68 File Offset: 0x0002D068
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Broadcast._members;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0002EE70 File Offset: 0x0002D070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Broadcast._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0002EE94 File Offset: 0x0002D094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Broadcast._members.ManagedPeerType;
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Broadcast(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		[Register(".ctor", "()V", "")]
		public Broadcast() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Broadcast._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Broadcast._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0002EF10 File Offset: 0x0002D110
		[Register("addBroadcastListener", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void AddBroadcastListener(string name, string dataScheme, JSONArray actions, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(dataScheme);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((actions == null) ? IntPtr.Zero : actions.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Broadcast._members.StaticMethods.InvokeVoidMethod("addBroadcastListener.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(actions);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
		[Register("addBroadcastListener", "(Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void AddBroadcastListener(string name, JSONArray actions, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((actions == null) ? IntPtr.Zero : actions.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Broadcast._members.StaticMethods.InvokeVoidMethod("addBroadcastListener.(Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(actions);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0002F090 File Offset: 0x0002D290
		[Register("removeAllBroadcastListeners", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RemoveAllBroadcastListeners(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Broadcast._members.StaticMethods.InvokeVoidMethod("removeAllBroadcastListeners.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		[Register("removeBroadcastListener", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RemoveBroadcastListener(string name, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Broadcast._members.StaticMethods.InvokeVoidMethod("removeBroadcastListener.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000447 RID: 1095
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Broadcast", typeof(Broadcast));
	}
}
