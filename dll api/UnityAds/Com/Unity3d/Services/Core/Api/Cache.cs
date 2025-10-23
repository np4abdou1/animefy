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
	// Token: 0x02000185 RID: 389
	[Register("com/unity3d/services/core/api/Cache", DoNotGenerateAcw = true)]
	public class Cache : Java.Lang.Object
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0002F194 File Offset: 0x0002D394
		internal static IntPtr class_ref
		{
			get
			{
				return Cache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Cache._members;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Cache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Cache._members.ManagedPeerType;
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Cache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		[Register(".ctor", "()V", "")]
		public Cache() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Cache._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Cache._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0002F260 File Offset: 0x0002D460
		[Register("deleteFile", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void DeleteFile(string fileId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("deleteFile.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
		[Register("download", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Download(string url, string fileId, JSONArray headers, Java.Lang.Boolean append, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((headers == null) ? IntPtr.Zero : headers.Handle);
				ptr[3] = new JniArgumentValue((append == null) ? IntPtr.Zero : append.Handle);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("download.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(headers);
				GC.KeepAlive(append);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x0002F3E4 File Offset: 0x0002D5E4
		[Register("getCacheDirectoryExists", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCacheDirectoryExists(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getCacheDirectoryExists.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0002F448 File Offset: 0x0002D648
		[Register("getCacheDirectoryType", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCacheDirectoryType(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getCacheDirectoryType.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x0002F4AC File Offset: 0x0002D6AC
		[Register("getFileContent", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFileContent(string fileId, string encoding, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			IntPtr intPtr2 = JNIEnv.NewString(encoding);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getFileContent.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0002F554 File Offset: 0x0002D754
		[Register("getFileInfo", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFileInfo(string fileId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getFileInfo.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x0002F5D8 File Offset: 0x0002D7D8
		[Register("getFilePath", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFilePath(string fileId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getFilePath.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0002F65C File Offset: 0x0002D85C
		[Register("getFiles", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFiles(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getFiles.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0002F6C0 File Offset: 0x0002D8C0
		[Register("getFreeSpace", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFreeSpace(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getFreeSpace.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0002F724 File Offset: 0x0002D924
		[Register("getHash", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetHash(string fileId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getHash.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[Register("getMetaData", "(Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetMetaData(string fileId, JSONArray requestedMetaDatas, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((requestedMetaDatas == null) ? IntPtr.Zero : requestedMetaDatas.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getMetaData.(Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(requestedMetaDatas);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0002F858 File Offset: 0x0002DA58
		[Register("getProgressInterval", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetProgressInterval(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getProgressInterval.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0002F8BC File Offset: 0x0002DABC
		[Register("getTimeouts", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTimeouts(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getTimeouts.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0002F920 File Offset: 0x0002DB20
		[Register("getTotalSpace", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTotalSpace(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("getTotalSpace.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0002F984 File Offset: 0x0002DB84
		[Register("isCaching", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsCaching(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("isCaching.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		[Register("recreateCacheDirectory", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RecreateCacheDirectory(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("recreateCacheDirectory.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		[Register("setFileContent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetFileContent(string fileId, string encoding, string content, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(fileId);
			IntPtr intPtr2 = JNIEnv.NewString(encoding);
			IntPtr intPtr3 = JNIEnv.NewString(content);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("setFileContent.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0002FB14 File Offset: 0x0002DD14
		[Register("setProgressInterval", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetProgressInterval(Integer interval, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((interval == null) ? IntPtr.Zero : interval.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("setProgressInterval.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(interval);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0002FBA0 File Offset: 0x0002DDA0
		[Register("setTimeouts", "(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetTimeouts(Integer connectTimeout, Integer readTimeout, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[1] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("setTimeouts.(Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0002FC58 File Offset: 0x0002DE58
		[Register("stop", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Stop(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Cache._members.StaticMethods.InvokeVoidMethod("stop.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000448 RID: 1096
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Cache", typeof(Cache));
	}
}
