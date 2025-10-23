using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000190 RID: 400
	[Register("com/unity3d/services/core/api/Preferences", DoNotGenerateAcw = true)]
	public class Preferences : Java.Lang.Object
	{
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00032874 File Offset: 0x00030A74
		internal static IntPtr class_ref
		{
			get
			{
				return Preferences._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00032898 File Offset: 0x00030A98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Preferences._members;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000328A0 File Offset: 0x00030AA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Preferences._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000328C4 File Offset: 0x00030AC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Preferences._members.ManagedPeerType;
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Preferences(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000328D0 File Offset: 0x00030AD0
		[Register(".ctor", "()V", "")]
		public Preferences() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Preferences._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Preferences._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00032940 File Offset: 0x00030B40
		[Register("getBoolean", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBoolean(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("getBoolean.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000329E8 File Offset: 0x00030BE8
		[Register("getFloat", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFloat(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("getFloat.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00032A90 File Offset: 0x00030C90
		[Register("getInt", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetInt(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("getInt.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00032B38 File Offset: 0x00030D38
		[Register("getLong", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetLong(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("getLong.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[Register("getString", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetString(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("getString.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00032C88 File Offset: 0x00030E88
		[Register("hasKey", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void HasKey(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("hasKey.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00032D30 File Offset: 0x00030F30
		[Register("removeKey", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RemoveKey(string name, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("removeKey.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00032DD8 File Offset: 0x00030FD8
		[Register("setBoolean", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetBoolean(string name, string key, Java.Lang.Boolean value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("setBoolean.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00032EA8 File Offset: 0x000310A8
		[Register("setFloat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetFloat(string name, string key, Java.Lang.Double value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("setFloat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00032F78 File Offset: 0x00031178
		[Register("setInt", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetInt(string name, string key, Integer value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("setInt.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00033048 File Offset: 0x00031248
		[Register("setLong", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetLong(string name, string key, Long value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("setLong.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00033118 File Offset: 0x00031318
		[Register("setString", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetString(string name, string key, string value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			IntPtr intPtr3 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Preferences._members.StaticMethods.InvokeVoidMethod("setString.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000453 RID: 1107
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Preferences", typeof(Preferences));
	}
}
