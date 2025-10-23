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
	// Token: 0x02000195 RID: 405
	[Register("com/unity3d/services/core/api/Storage", DoNotGenerateAcw = true)]
	public class Storage : Java.Lang.Object
	{
		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000343D4 File Offset: 0x000325D4
		internal static IntPtr class_ref
		{
			get
			{
				return Storage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x000343F8 File Offset: 0x000325F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Storage._members;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00034400 File Offset: 0x00032600
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Storage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00034424 File Offset: 0x00032624
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Storage._members.ManagedPeerType;
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Storage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00034430 File Offset: 0x00032630
		[Register(".ctor", "()V", "")]
		public Storage() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Storage._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Storage._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000344A0 File Offset: 0x000326A0
		[Register("clear", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Clear(string type, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("clear.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00034524 File Offset: 0x00032724
		[Register("delete", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Delete(string type, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("delete.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000345CC File Offset: 0x000327CC
		[Register("get", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Get(string type, string key, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("get.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00034674 File Offset: 0x00032874
		[Register("getKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetKeys(string type, string key, Java.Lang.Boolean recursive, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((recursive == null) ? IntPtr.Zero : recursive.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("getKeys.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(recursive);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00034744 File Offset: 0x00032944
		[Register("read", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Read(string type, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("read.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000347C8 File Offset: 0x000329C8
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, Java.Lang.Boolean value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00034898 File Offset: 0x00032A98
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, Java.Lang.Double value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Double;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00034968 File Offset: 0x00032B68
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, Integer value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00034A38 File Offset: 0x00032C38
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, Long value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00034B08 File Offset: 0x00032D08
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, string value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			IntPtr intPtr3 = JNIEnv.NewString(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00034BD0 File Offset: 0x00032DD0
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, JSONArray value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00034CA0 File Offset: 0x00032EA0
		[Register("set", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Set(string type, string key, JSONObject value, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IntPtr intPtr2 = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("set.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONObject;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(value);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00034D70 File Offset: 0x00032F70
		[Register("write", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Write(string type, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Storage._members.StaticMethods.InvokeVoidMethod("write.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000458 RID: 1112
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Storage", typeof(Storage));
	}
}
