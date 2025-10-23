using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000B8 RID: 184
	[Register("com/unity3d/services/core/request/WebRequestThread", DoNotGenerateAcw = true)]
	public class WebRequestThread : Java.Lang.Object
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00012AD8 File Offset: 0x00010CD8
		internal static IntPtr class_ref
		{
			get
			{
				return WebRequestThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00012AFC File Offset: 0x00010CFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebRequestThread._members;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00012B04 File Offset: 0x00010D04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebRequestThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00012B28 File Offset: 0x00010D28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebRequestThread._members.ManagedPeerType;
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebRequestThread(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00012B34 File Offset: 0x00010D34
		[Register(".ctor", "()V", "")]
		public WebRequestThread() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebRequestThread._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebRequestThread._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00012BA2 File Offset: 0x00010DA2
		[Register("cancel", "()V", "")]
		public static void Cancel()
		{
			WebRequestThread._members.StaticMethods.InvokeVoidMethod("cancel.()V", null);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00012BBC File Offset: 0x00010DBC
		[Register("request", "(Ljava/lang/String;Lcom/unity3d/services/core/request/WebRequest$RequestType;Ljava/util/Map;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/request/IWebRequestListener;)V", "")]
		public unsafe static void Request(string url, WebRequest.RequestType requestType, IDictionary<string, IList<string>> headers, Integer connectTimeout, Integer readTimeout, IWebRequestListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((requestType == null) ? IntPtr.Zero : requestType.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[4] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[5] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				WebRequestThread._members.StaticMethods.InvokeVoidMethod("request.(Ljava/lang/String;Lcom/unity3d/services/core/request/WebRequest$RequestType;Ljava/util/Map;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/request/IWebRequestListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(requestType);
				GC.KeepAlive(headers);
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00012CF4 File Offset: 0x00010EF4
		[Register("request", "(Ljava/lang/String;Lcom/unity3d/services/core/request/WebRequest$RequestType;Ljava/util/Map;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/request/IWebRequestListener;)V", "")]
		public unsafe static void Request(string url, WebRequest.RequestType requestType, IDictionary<string, IList<string>> headers, string requestBody, Integer connectTimeout, Integer readTimeout, IWebRequestListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			IntPtr intPtr3 = JNIEnv.NewString(requestBody);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((requestType == null) ? IntPtr.Zero : requestType.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue((connectTimeout == null) ? IntPtr.Zero : connectTimeout.Handle);
				ptr[5] = new JniArgumentValue((readTimeout == null) ? IntPtr.Zero : readTimeout.Handle);
				ptr[6] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				WebRequestThread._members.StaticMethods.InvokeVoidMethod("request.(Ljava/lang/String;Lcom/unity3d/services/core/request/WebRequest$RequestType;Ljava/util/Map;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/Integer;Lcom/unity3d/services/core/request/IWebRequestListener;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(requestType);
				GC.KeepAlive(headers);
				GC.KeepAlive(connectTimeout);
				GC.KeepAlive(readTimeout);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00012E54 File Offset: 0x00011054
		[Register("reset", "()V", "")]
		public static void Reset()
		{
			WebRequestThread._members.StaticMethods.InvokeVoidMethod("reset.()V", null);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00012E6C File Offset: 0x0001106C
		[Register("resolve", "(Ljava/lang/String;Lcom/unity3d/services/core/request/IResolveHostListener;)Z", "")]
		public unsafe static bool Resolve(string host, IResolveHostListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(host);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				result = WebRequestThread._members.StaticMethods.InvokeBooleanMethod("resolve.(Ljava/lang/String;Lcom/unity3d/services/core/request/IResolveHostListener;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
			}
			return result;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00012EF8 File Offset: 0x000110F8
		[Register("setConcurrentRequestCount", "(I)V", "")]
		public unsafe static void SetConcurrentRequestCount(int count)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(count);
			WebRequestThread._members.StaticMethods.InvokeVoidMethod("setConcurrentRequestCount.(I)V", ptr);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00012F34 File Offset: 0x00011134
		[Register("setKeepAliveTime", "(J)V", "")]
		public unsafe static void SetKeepAliveTime(long milliseconds)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(milliseconds);
			WebRequestThread._members.StaticMethods.InvokeVoidMethod("setKeepAliveTime.(J)V", ptr);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00012F70 File Offset: 0x00011170
		[Register("setMaximumPoolSize", "(I)V", "")]
		public unsafe static void SetMaximumPoolSize(int count)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(count);
			WebRequestThread._members.StaticMethods.InvokeVoidMethod("setMaximumPoolSize.(I)V", ptr);
		}

		// Token: 0x040001A0 RID: 416
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequestThread", typeof(WebRequestThread));
	}
}
