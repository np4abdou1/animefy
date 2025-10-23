using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Net;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AF RID: 175
	[Register("com/unity3d/services/core/request/WebRequest", DoNotGenerateAcw = true)]
	public class WebRequest : Java.Lang.Object
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00011604 File Offset: 0x0000F804
		internal static IntPtr class_ref
		{
			get
			{
				return WebRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00011628 File Offset: 0x0000F828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebRequest._members;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00011630 File Offset: 0x0000F830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebRequest._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00011654 File Offset: 0x0000F854
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebRequest._members.ManagedPeerType;
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebRequest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00011660 File Offset: 0x0000F860
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe WebRequest(string url, string requestType) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(requestType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(WebRequest._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebRequest._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00011724 File Offset: 0x0000F924
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe WebRequest(string url, string requestType, IDictionary<string, IList<string>> headers) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(requestType);
			IntPtr intPtr3 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				base.SetHandle(WebRequest._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebRequest._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(headers);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00011814 File Offset: 0x0000FA14
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;II)V", "")]
		public unsafe WebRequest(string url, string requestType, IDictionary<string, IList<string>> headers, int connectTimeout, int readTimeout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(url);
			IntPtr intPtr2 = JNIEnv.NewString(requestType);
			IntPtr intPtr3 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(connectTimeout);
				ptr[4] = new JniArgumentValue(readTimeout);
				base.SetHandle(WebRequest._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				WebRequest._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;II)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(headers);
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00011930 File Offset: 0x0000FB30
		private static Delegate GetGetConnectTimeoutHandler()
		{
			if (WebRequest.cb_getConnectTimeout == null)
			{
				WebRequest.cb_getConnectTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebRequest.n_GetConnectTimeout));
			}
			return WebRequest.cb_getConnectTimeout;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00011954 File Offset: 0x0000FB54
		private static int n_GetConnectTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConnectTimeout;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00011963 File Offset: 0x0000FB63
		private static Delegate GetSetConnectTimeout_IHandler()
		{
			if (WebRequest.cb_setConnectTimeout_I == null)
			{
				WebRequest.cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(WebRequest.n_SetConnectTimeout_I));
			}
			return WebRequest.cb_setConnectTimeout_I;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00011987 File Offset: 0x0000FB87
		private static void n_SetConnectTimeout_I(IntPtr jnienv, IntPtr native__this, int timeout)
		{
			Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConnectTimeout = timeout;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00011997 File Offset: 0x0000FB97
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x000119B0 File Offset: 0x0000FBB0
		public unsafe virtual int ConnectTimeout
		{
			[Register("getConnectTimeout", "()I", "GetGetConnectTimeoutHandler")]
			get
			{
				return WebRequest._members.InstanceMethods.InvokeVirtualInt32Method("getConnectTimeout.()I", this, null);
			}
			[Register("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("setConnectTimeout.(I)V", this, ptr);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000119EB File Offset: 0x0000FBEB
		private static Delegate GetGetContentLengthHandler()
		{
			if (WebRequest.cb_getContentLength == null)
			{
				WebRequest.cb_getContentLength = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(WebRequest.n_GetContentLength));
			}
			return WebRequest.cb_getContentLength;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00011A0F File Offset: 0x0000FC0F
		private static long n_GetContentLength(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentLength;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00011A1E File Offset: 0x0000FC1E
		public virtual long ContentLength
		{
			[Register("getContentLength", "()J", "GetGetContentLengthHandler")]
			get
			{
				return WebRequest._members.InstanceMethods.InvokeVirtualInt64Method("getContentLength.()J", this, null);
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00011A37 File Offset: 0x0000FC37
		private static Delegate GetGetHeadersHandler()
		{
			if (WebRequest.cb_getHeaders == null)
			{
				WebRequest.cb_getHeaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetHeaders));
			}
			return WebRequest.cb_getHeaders;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00011A5B File Offset: 0x0000FC5B
		private static IntPtr n_GetHeaders(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, IList<string>>.ToLocalJniHandle(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Headers);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x00011A70 File Offset: 0x0000FC70
		public virtual IDictionary<string, IList<string>> Headers
		{
			[Register("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get
			{
				return JavaDictionary<string, IList<string>>.FromJniHandle(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaders.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00011AA2 File Offset: 0x0000FCA2
		private static Delegate GetIsCanceledHandler()
		{
			if (WebRequest.cb_isCanceled == null)
			{
				WebRequest.cb_isCanceled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(WebRequest.n_IsCanceled));
			}
			return WebRequest.cb_isCanceled;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00011AC6 File Offset: 0x0000FCC6
		private static bool n_IsCanceled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCanceled;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x00011AD5 File Offset: 0x0000FCD5
		public virtual bool IsCanceled
		{
			[Register("isCanceled", "()Z", "GetIsCanceledHandler")]
			get
			{
				return WebRequest._members.InstanceMethods.InvokeVirtualBooleanMethod("isCanceled.()Z", this, null);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00011AEE File Offset: 0x0000FCEE
		private static Delegate GetGetQueryHandler()
		{
			if (WebRequest.cb_getQuery == null)
			{
				WebRequest.cb_getQuery = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetQuery));
			}
			return WebRequest.cb_getQuery;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00011B12 File Offset: 0x0000FD12
		private static IntPtr n_GetQuery(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Query);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00011B28 File Offset: 0x0000FD28
		public virtual string Query
		{
			[Register("getQuery", "()Ljava/lang/String;", "GetGetQueryHandler")]
			get
			{
				return JNIEnv.GetString(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getQuery.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00011B5A File Offset: 0x0000FD5A
		private static Delegate GetGetReadTimeoutHandler()
		{
			if (WebRequest.cb_getReadTimeout == null)
			{
				WebRequest.cb_getReadTimeout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebRequest.n_GetReadTimeout));
			}
			return WebRequest.cb_getReadTimeout;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00011B7E File Offset: 0x0000FD7E
		private static int n_GetReadTimeout(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReadTimeout;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00011B8D File Offset: 0x0000FD8D
		private static Delegate GetSetReadTimeout_IHandler()
		{
			if (WebRequest.cb_setReadTimeout_I == null)
			{
				WebRequest.cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(WebRequest.n_SetReadTimeout_I));
			}
			return WebRequest.cb_setReadTimeout_I;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00011BB1 File Offset: 0x0000FDB1
		private static void n_SetReadTimeout_I(IntPtr jnienv, IntPtr native__this, int readTimeout)
		{
			Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ReadTimeout = readTimeout;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00011BC1 File Offset: 0x0000FDC1
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public unsafe virtual int ReadTimeout
		{
			[Register("getReadTimeout", "()I", "GetGetReadTimeoutHandler")]
			get
			{
				return WebRequest._members.InstanceMethods.InvokeVirtualInt32Method("getReadTimeout.()I", this, null);
			}
			[Register("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("setReadTimeout.(I)V", this, ptr);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00011C17 File Offset: 0x0000FE17
		private static Delegate GetGetResponseCodeHandler()
		{
			if (WebRequest.cb_getResponseCode == null)
			{
				WebRequest.cb_getResponseCode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WebRequest.n_GetResponseCode));
			}
			return WebRequest.cb_getResponseCode;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00011C3B File Offset: 0x0000FE3B
		private static int n_GetResponseCode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResponseCode;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00011C4A File Offset: 0x0000FE4A
		public virtual int ResponseCode
		{
			[Register("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get
			{
				return WebRequest._members.InstanceMethods.InvokeVirtualInt32Method("getResponseCode.()I", this, null);
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00011C63 File Offset: 0x0000FE63
		private static Delegate GetGetResponseHeadersHandler()
		{
			if (WebRequest.cb_getResponseHeaders == null)
			{
				WebRequest.cb_getResponseHeaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetResponseHeaders));
			}
			return WebRequest.cb_getResponseHeaders;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00011C87 File Offset: 0x0000FE87
		private static IntPtr n_GetResponseHeaders(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, IList<string>>.ToLocalJniHandle(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResponseHeaders);
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00011C9C File Offset: 0x0000FE9C
		public virtual IDictionary<string, IList<string>> ResponseHeaders
		{
			[Register("getResponseHeaders", "()Ljava/util/Map;", "GetGetResponseHeadersHandler")]
			get
			{
				return JavaDictionary<string, IList<string>>.FromJniHandle(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getResponseHeaders.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00011CCE File Offset: 0x0000FECE
		private static Delegate GetGetUrlHandler()
		{
			if (WebRequest.cb_getUrl == null)
			{
				WebRequest.cb_getUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetUrl));
			}
			return WebRequest.cb_getUrl;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00011CF2 File Offset: 0x0000FEF2
		private static IntPtr n_GetUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Url);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00011D08 File Offset: 0x0000FF08
		public virtual URL Url
		{
			[Register("getUrl", "()Ljava/net/URL;", "GetGetUrlHandler")]
			get
			{
				return Java.Lang.Object.GetObject<URL>(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getUrl.()Ljava/net/URL;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00011D3A File Offset: 0x0000FF3A
		private static Delegate GetCancelHandler()
		{
			if (WebRequest.cb_cancel == null)
			{
				WebRequest.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(WebRequest.n_Cancel));
			}
			return WebRequest.cb_cancel;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00011D5E File Offset: 0x0000FF5E
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00011D6D File Offset: 0x0000FF6D
		[Register("cancel", "()V", "GetCancelHandler")]
		public virtual void Cancel()
		{
			WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00011D86 File Offset: 0x0000FF86
		private static Delegate GetGetBodyHandler()
		{
			if (WebRequest.cb_getBody == null)
			{
				WebRequest.cb_getBody = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetBody));
			}
			return WebRequest.cb_getBody;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00011DAA File Offset: 0x0000FFAA
		private static IntPtr n_GetBody(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBody());
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Register("getBody", "()[B", "GetGetBodyHandler")]
		public virtual byte[] GetBody()
		{
			return (byte[])JNIEnv.GetArray(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getBody.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00011E01 File Offset: 0x00010001
		private static Delegate GetGetRequestTypeHandler()
		{
			if (WebRequest.cb_getRequestType == null)
			{
				WebRequest.cb_getRequestType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_GetRequestType));
			}
			return WebRequest.cb_getRequestType;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00011E25 File Offset: 0x00010025
		private static IntPtr n_GetRequestType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRequestType());
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00011E3C File Offset: 0x0001003C
		[Register("getRequestType", "()Ljava/lang/String;", "GetGetRequestTypeHandler")]
		public virtual string GetRequestType()
		{
			return JNIEnv.GetString(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("getRequestType.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00011E6E File Offset: 0x0001006E
		private static Delegate GetMakeRequestHandler()
		{
			if (WebRequest.cb_makeRequest == null)
			{
				WebRequest.cb_makeRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebRequest.n_MakeRequest));
			}
			return WebRequest.cb_makeRequest;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00011E92 File Offset: 0x00010092
		private static IntPtr n_MakeRequest(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MakeRequest());
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00011EA8 File Offset: 0x000100A8
		[Register("makeRequest", "()Ljava/lang/String;", "GetMakeRequestHandler")]
		public virtual string MakeRequest()
		{
			return JNIEnv.GetString(WebRequest._members.InstanceMethods.InvokeVirtualObjectMethod("makeRequest.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00011EDA File Offset: 0x000100DA
		private static Delegate GetMakeStreamRequest_Ljava_io_OutputStream_Handler()
		{
			if (WebRequest.cb_makeStreamRequest_Ljava_io_OutputStream_ == null)
			{
				WebRequest.cb_makeStreamRequest_Ljava_io_OutputStream_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_J(WebRequest.n_MakeStreamRequest_Ljava_io_OutputStream_));
			}
			return WebRequest.cb_makeStreamRequest_Ljava_io_OutputStream_;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00011F00 File Offset: 0x00010100
		private static long n_MakeStreamRequest_Ljava_io_OutputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_outputStream)
		{
			WebRequest @object = Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Stream outputStream = OutputStreamInvoker.FromJniHandle(native_outputStream, JniHandleOwnership.DoNotTransfer);
			return @object.MakeStreamRequest(outputStream);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00011F24 File Offset: 0x00010124
		[Register("makeStreamRequest", "(Ljava/io/OutputStream;)J", "GetMakeStreamRequest_Ljava_io_OutputStream_Handler")]
		public unsafe virtual long MakeStreamRequest(Stream outputStream)
		{
			IntPtr intPtr = OutputStreamAdapter.ToLocalJniHandle(outputStream);
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = WebRequest._members.InstanceMethods.InvokeVirtualInt64Method("makeStreamRequest.(Ljava/io/OutputStream;)J", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(outputStream);
			}
			return result;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00011F88 File Offset: 0x00010188
		private static Delegate GetSetBody_arrayBHandler()
		{
			if (WebRequest.cb_setBody_arrayB == null)
			{
				WebRequest.cb_setBody_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebRequest.n_SetBody_arrayB));
			}
			return WebRequest.cb_setBody_arrayB;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00011FAC File Offset: 0x000101AC
		private static void n_SetBody_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_body)
		{
			WebRequest @object = Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_body, JniHandleOwnership.DoNotTransfer, typeof(byte));
			@object.SetBody(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_body);
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Register("setBody", "([B)V", "GetSetBody_arrayBHandler")]
		public unsafe virtual void SetBody(byte[] body)
		{
			IntPtr intPtr = JNIEnv.NewArray(body);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("setBody.([B)V", this, ptr);
			}
			finally
			{
				if (body != null)
				{
					JNIEnv.CopyArray(intPtr, body);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(body);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00012054 File Offset: 0x00010254
		private static Delegate GetSetBody_Ljava_lang_String_Handler()
		{
			if (WebRequest.cb_setBody_Ljava_lang_String_ == null)
			{
				WebRequest.cb_setBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebRequest.n_SetBody_Ljava_lang_String_));
			}
			return WebRequest.cb_setBody_Ljava_lang_String_;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00012078 File Offset: 0x00010278
		private static void n_SetBody_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_body)
		{
			WebRequest @object = Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_body, JniHandleOwnership.DoNotTransfer);
			@object.SetBody(@string);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001209C File Offset: 0x0001029C
		[Register("setBody", "(Ljava/lang/String;)V", "GetSetBody_Ljava_lang_String_Handler")]
		public unsafe virtual void SetBody(string body)
		{
			IntPtr intPtr = JNIEnv.NewString(body);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("setBody.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000120F8 File Offset: 0x000102F8
		private static Delegate GetSetProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_Handler()
		{
			if (WebRequest.cb_setProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_ == null)
			{
				WebRequest.cb_setProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebRequest.n_SetProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_));
			}
			return WebRequest.cb_setProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001211C File Offset: 0x0001031C
		private static void n_SetProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			WebRequest @object = Java.Lang.Object.GetObject<WebRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IWebRequestProgressListener object2 = Java.Lang.Object.GetObject<IWebRequestProgressListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetProgressListener(object2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00012140 File Offset: 0x00010340
		[Register("setProgressListener", "(Lcom/unity3d/services/core/request/IWebRequestProgressListener;)V", "GetSetProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_Handler")]
		public unsafe virtual void SetProgressListener(IWebRequestProgressListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				WebRequest._members.InstanceMethods.InvokeVirtualVoidMethod("setProgressListener.(Lcom/unity3d/services/core/request/IWebRequestProgressListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000678 RID: 1656 RVA: 0x000121A8 File Offset: 0x000103A8
		// (remove) Token: 0x06000679 RID: 1657 RVA: 0x000121F4 File Offset: 0x000103F4
		public event EventHandler<RequestProgressEventArgs> RequestProgress
		{
			add
			{
				EventHelper.AddEventHandler<IWebRequestProgressListener, IWebRequestProgressListenerImplementor>(ref this.weak_implementor_SetProgressListener, new Func<IWebRequestProgressListenerImplementor>(this.__CreateIWebRequestProgressListenerImplementor), new Action<IWebRequestProgressListener>(this.SetProgressListener), delegate(IWebRequestProgressListenerImplementor __h)
				{
					__h.OnRequestProgressHandler = (EventHandler<RequestProgressEventArgs>)Delegate.Combine(__h.OnRequestProgressHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IWebRequestProgressListener, IWebRequestProgressListenerImplementor>(ref this.weak_implementor_SetProgressListener, new Func<IWebRequestProgressListenerImplementor, bool>(IWebRequestProgressListenerImplementor.__IsEmpty), delegate(IWebRequestProgressListener __v)
				{
					this.SetProgressListener(null);
				}, delegate(IWebRequestProgressListenerImplementor __h)
				{
					__h.OnRequestProgressHandler = (EventHandler<RequestProgressEventArgs>)Delegate.Remove(__h.OnRequestProgressHandler, value);
				});
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600067A RID: 1658 RVA: 0x00012244 File Offset: 0x00010444
		// (remove) Token: 0x0600067B RID: 1659 RVA: 0x00012290 File Offset: 0x00010490
		public event EventHandler<RequestStartEventArgs> RequestStart
		{
			add
			{
				EventHelper.AddEventHandler<IWebRequestProgressListener, IWebRequestProgressListenerImplementor>(ref this.weak_implementor_SetProgressListener, new Func<IWebRequestProgressListenerImplementor>(this.__CreateIWebRequestProgressListenerImplementor), new Action<IWebRequestProgressListener>(this.SetProgressListener), delegate(IWebRequestProgressListenerImplementor __h)
				{
					__h.OnRequestStartHandler = (EventHandler<RequestStartEventArgs>)Delegate.Combine(__h.OnRequestStartHandler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<IWebRequestProgressListener, IWebRequestProgressListenerImplementor>(ref this.weak_implementor_SetProgressListener, new Func<IWebRequestProgressListenerImplementor, bool>(IWebRequestProgressListenerImplementor.__IsEmpty), delegate(IWebRequestProgressListener __v)
				{
					this.SetProgressListener(null);
				}, delegate(IWebRequestProgressListenerImplementor __h)
				{
					__h.OnRequestStartHandler = (EventHandler<RequestStartEventArgs>)Delegate.Remove(__h.OnRequestStartHandler, value);
				});
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000122E0 File Offset: 0x000104E0
		private IWebRequestProgressListenerImplementor __CreateIWebRequestProgressListenerImplementor()
		{
			return new IWebRequestProgressListenerImplementor(this);
		}

		// Token: 0x0400017F RID: 383
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequest", typeof(WebRequest));

		// Token: 0x04000180 RID: 384
		private static Delegate cb_getConnectTimeout;

		// Token: 0x04000181 RID: 385
		private static Delegate cb_setConnectTimeout_I;

		// Token: 0x04000182 RID: 386
		private static Delegate cb_getContentLength;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_getHeaders;

		// Token: 0x04000184 RID: 388
		private static Delegate cb_isCanceled;

		// Token: 0x04000185 RID: 389
		private static Delegate cb_getQuery;

		// Token: 0x04000186 RID: 390
		private static Delegate cb_getReadTimeout;

		// Token: 0x04000187 RID: 391
		private static Delegate cb_setReadTimeout_I;

		// Token: 0x04000188 RID: 392
		private static Delegate cb_getResponseCode;

		// Token: 0x04000189 RID: 393
		private static Delegate cb_getResponseHeaders;

		// Token: 0x0400018A RID: 394
		private static Delegate cb_getUrl;

		// Token: 0x0400018B RID: 395
		private static Delegate cb_cancel;

		// Token: 0x0400018C RID: 396
		private static Delegate cb_getBody;

		// Token: 0x0400018D RID: 397
		private static Delegate cb_getRequestType;

		// Token: 0x0400018E RID: 398
		private static Delegate cb_makeRequest;

		// Token: 0x0400018F RID: 399
		private static Delegate cb_makeStreamRequest_Ljava_io_OutputStream_;

		// Token: 0x04000190 RID: 400
		private static Delegate cb_setBody_arrayB;

		// Token: 0x04000191 RID: 401
		private static Delegate cb_setBody_Ljava_lang_String_;

		// Token: 0x04000192 RID: 402
		private static Delegate cb_setProgressListener_Lcom_unity3d_services_core_request_IWebRequestProgressListener_;

		// Token: 0x04000193 RID: 403
		private WeakReference weak_implementor_SetProgressListener;

		// Token: 0x020000B0 RID: 176
		[Register("com/unity3d/services/core/request/WebRequest$RequestType", DoNotGenerateAcw = true)]
		public sealed class RequestType : Java.Lang.Enum
		{
			// Token: 0x17000207 RID: 519
			// (get) Token: 0x0600067E RID: 1662 RVA: 0x00012304 File Offset: 0x00010504
			[Register("GET")]
			public static WebRequest.RequestType Get
			{
				get
				{
					return Java.Lang.Object.GetObject<WebRequest.RequestType>(WebRequest.RequestType._members.StaticFields.GetObjectValue("GET.Lcom/unity3d/services/core/request/WebRequest$RequestType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x00012334 File Offset: 0x00010534
			[Register("HEAD")]
			public static WebRequest.RequestType Head
			{
				get
				{
					return Java.Lang.Object.GetObject<WebRequest.RequestType>(WebRequest.RequestType._members.StaticFields.GetObjectValue("HEAD.Lcom/unity3d/services/core/request/WebRequest$RequestType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x06000680 RID: 1664 RVA: 0x00012364 File Offset: 0x00010564
			[Register("POST")]
			public static WebRequest.RequestType Post
			{
				get
				{
					return Java.Lang.Object.GetObject<WebRequest.RequestType>(WebRequest.RequestType._members.StaticFields.GetObjectValue("POST.Lcom/unity3d/services/core/request/WebRequest$RequestType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x00012394 File Offset: 0x00010594
			internal static IntPtr class_ref
			{
				get
				{
					return WebRequest.RequestType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x000123B8 File Offset: 0x000105B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return WebRequest.RequestType._members;
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x000123C0 File Offset: 0x000105C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return WebRequest.RequestType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x06000684 RID: 1668 RVA: 0x000123E4 File Offset: 0x000105E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return WebRequest.RequestType._members.ManagedPeerType;
				}
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x0000256C File Offset: 0x0000076C
			internal RequestType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x000123F0 File Offset: 0x000105F0
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequest$RequestType;", "")]
			public unsafe static WebRequest.RequestType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				WebRequest.RequestType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<WebRequest.RequestType>(WebRequest.RequestType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/WebRequest$RequestType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x0001245C File Offset: 0x0001065C
			[Register("values", "()[Lcom/unity3d/services/core/request/WebRequest$RequestType;", "")]
			public static WebRequest.RequestType[] Values()
			{
				return (WebRequest.RequestType[])JNIEnv.GetArray(WebRequest.RequestType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/WebRequest$RequestType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(WebRequest.RequestType));
			}

			// Token: 0x04000194 RID: 404
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/WebRequest$RequestType", typeof(WebRequest.RequestType));
		}
	}
}
