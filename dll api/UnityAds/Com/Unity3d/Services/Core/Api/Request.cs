using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000191 RID: 401
	[Register("com/unity3d/services/core/api/Request", DoNotGenerateAcw = true)]
	public class Request : Java.Lang.Object
	{
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x000331FC File Offset: 0x000313FC
		internal static IntPtr class_ref
		{
			get
			{
				return Request._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00033220 File Offset: 0x00031420
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Request._members;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00033228 File Offset: 0x00031428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Request._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x0003324C File Offset: 0x0003144C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Request._members.ManagedPeerType;
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Request(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00033258 File Offset: 0x00031458
		[Register(".ctor", "()V", "")]
		public Request() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Request._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Request._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000332C8 File Offset: 0x000314C8
		[Register("get", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Get(string id, string url, JSONArray headers, Integer connectTimeout, Integer readTimeout, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((headers == null) ? IntPtr.Zero : headers.Handle);
				ptr[3] = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[4] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[5] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("get.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(headers);
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000333F4 File Offset: 0x000315F4
		[Register("getHeadersMap", "(Lorg/json/JSONArray;)Ljava/util/HashMap;", "")]
		public unsafe static IDictionary<string, IList<string>> GetHeadersMap(JSONArray headers)
		{
			IDictionary<string, IList<string>> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((headers == null) ? IntPtr.Zero : headers.Handle);
				result = JavaDictionary<string, IList<string>>.FromJniHandle(Request._members.StaticMethods.InvokeObjectMethod("getHeadersMap.(Lorg/json/JSONArray;)Ljava/util/HashMap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(headers);
			}
			return result;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00033468 File Offset: 0x00031668
		[Register("getResponseHeadersMap", "(Ljava/util/Map;)Lorg/json/JSONArray;", "")]
		public unsafe static JSONArray GetResponseHeadersMap(IDictionary<string, IList<string>> responseHeaders)
		{
			IntPtr intPtr = JavaDictionary<string, IList<string>>.ToLocalJniHandle(responseHeaders);
			JSONArray @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<JSONArray>(Request._members.StaticMethods.InvokeObjectMethod("getResponseHeadersMap.(Ljava/util/Map;)Lorg/json/JSONArray;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(responseHeaders);
			}
			return @object;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000334D8 File Offset: 0x000316D8
		[Register("head", "(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Head(string id, string url, JSONArray headers, Integer connectTimeout, Integer readTimeout, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = JNIEnv.NewString(url);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((headers == null) ? IntPtr.Zero : headers.Handle);
				ptr[3] = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[4] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[5] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("head.(Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(headers);
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00033604 File Offset: 0x00031804
		[Register("post", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Post(string id, string url, string requestBody, JSONArray headers, Integer connectTimeout, Integer readTimeout, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = JNIEnv.NewString(url);
			IntPtr intPtr3 = JNIEnv.NewString(requestBody);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue((headers == null) ? IntPtr.Zero : headers.Handle);
				ptr[4] = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[5] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[6] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("post.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/json/JSONArray;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(headers);
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00033758 File Offset: 0x00031958
		[Register("setConcurrentRequestCount", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetConcurrentRequestCount(Integer count, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((count == null) ? IntPtr.Zero : count.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("setConcurrentRequestCount.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(count);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000337E4 File Offset: 0x000319E4
		[Register("setKeepAliveTime", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetKeepAliveTime(Integer milliseconds, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((milliseconds == null) ? IntPtr.Zero : milliseconds.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("setKeepAliveTime.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(milliseconds);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00033870 File Offset: 0x00031A70
		[Register("setMaximumPoolSize", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetMaximumPoolSize(Integer count, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((count == null) ? IntPtr.Zero : count.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Request._members.StaticMethods.InvokeVoidMethod("setMaximumPoolSize.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(count);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000454 RID: 1108
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Request", typeof(Request));
	}
}
