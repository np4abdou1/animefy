using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Webkit
{
	// Token: 0x02000103 RID: 259
	[Register("android/webkit/WebResourceRequest", DoNotGenerateAcw = true)]
	internal class IWebResourceRequestInvoker : Java.Lang.Object, IWebResourceRequest, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0000E118 File Offset: 0x0000C318
		private static IntPtr java_class_ref
		{
			get
			{
				return IWebResourceRequestInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0000E13C File Offset: 0x0000C33C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWebResourceRequestInvoker._members;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0000E143 File Offset: 0x0000C343
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0000E14B File Offset: 0x0000C34B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWebResourceRequestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000E157 File Offset: 0x0000C357
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWebResourceRequestInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.webkit.WebResourceRequest'.");
			}
			return handle;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000E182 File Offset: 0x0000C382
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		public IWebResourceRequestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWebResourceRequestInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000E1EC File Offset: 0x0000C3EC
		private static Delegate GetHasGestureHandler()
		{
			if (IWebResourceRequestInvoker.cb_hasGesture == null)
			{
				IWebResourceRequestInvoker.cb_hasGesture = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWebResourceRequestInvoker.n_HasGesture));
			}
			return IWebResourceRequestInvoker.cb_hasGesture;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000E210 File Offset: 0x0000C410
		private static bool n_HasGesture(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasGesture;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0000E21F File Offset: 0x0000C41F
		public bool HasGesture
		{
			get
			{
				if (this.id_hasGesture == IntPtr.Zero)
				{
					this.id_hasGesture = JNIEnv.GetMethodID(this.class_ref, "hasGesture", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasGesture);
			}
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000E25F File Offset: 0x0000C45F
		private static Delegate GetIsForMainFrameHandler()
		{
			if (IWebResourceRequestInvoker.cb_isForMainFrame == null)
			{
				IWebResourceRequestInvoker.cb_isForMainFrame = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWebResourceRequestInvoker.n_IsForMainFrame));
			}
			return IWebResourceRequestInvoker.cb_isForMainFrame;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000E283 File Offset: 0x0000C483
		private static bool n_IsForMainFrame(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsForMainFrame;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0000E292 File Offset: 0x0000C492
		public bool IsForMainFrame
		{
			get
			{
				if (this.id_isForMainFrame == IntPtr.Zero)
				{
					this.id_isForMainFrame = JNIEnv.GetMethodID(this.class_ref, "isForMainFrame", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isForMainFrame);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000E2D2 File Offset: 0x0000C4D2
		private static Delegate GetIsRedirectHandler()
		{
			if (IWebResourceRequestInvoker.cb_isRedirect == null)
			{
				IWebResourceRequestInvoker.cb_isRedirect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IWebResourceRequestInvoker.n_IsRedirect));
			}
			return IWebResourceRequestInvoker.cb_isRedirect;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000E2F6 File Offset: 0x0000C4F6
		private static bool n_IsRedirect(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRedirect;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0000E305 File Offset: 0x0000C505
		public bool IsRedirect
		{
			get
			{
				if (this.id_isRedirect == IntPtr.Zero)
				{
					this.id_isRedirect = JNIEnv.GetMethodID(this.class_ref, "isRedirect", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isRedirect);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0000E345 File Offset: 0x0000C545
		private static Delegate GetGetMethodHandler()
		{
			if (IWebResourceRequestInvoker.cb_getMethod == null)
			{
				IWebResourceRequestInvoker.cb_getMethod = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebResourceRequestInvoker.n_GetMethod));
			}
			return IWebResourceRequestInvoker.cb_getMethod;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000E369 File Offset: 0x0000C569
		private static IntPtr n_GetMethod(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Method);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0000E380 File Offset: 0x0000C580
		public string Method
		{
			get
			{
				if (this.id_getMethod == IntPtr.Zero)
				{
					this.id_getMethod = JNIEnv.GetMethodID(this.class_ref, "getMethod", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		private static Delegate GetGetRequestHeadersHandler()
		{
			if (IWebResourceRequestInvoker.cb_getRequestHeaders == null)
			{
				IWebResourceRequestInvoker.cb_getRequestHeaders = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebResourceRequestInvoker.n_GetRequestHeaders));
			}
			return IWebResourceRequestInvoker.cb_getRequestHeaders;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000E3F5 File Offset: 0x0000C5F5
		private static IntPtr n_GetRequestHeaders(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestHeaders);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0000E40C File Offset: 0x0000C60C
		public IDictionary<string, string> RequestHeaders
		{
			get
			{
				if (this.id_getRequestHeaders == IntPtr.Zero)
				{
					this.id_getRequestHeaders = JNIEnv.GetMethodID(this.class_ref, "getRequestHeaders", "()Ljava/util/Map;");
				}
				return JavaDictionary<string, string>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getRequestHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000E45D File Offset: 0x0000C65D
		private static Delegate GetGetUrlHandler()
		{
			if (IWebResourceRequestInvoker.cb_getUrl == null)
			{
				IWebResourceRequestInvoker.cb_getUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWebResourceRequestInvoker.n_GetUrl));
			}
			return IWebResourceRequestInvoker.cb_getUrl;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000E481 File Offset: 0x0000C681
		private static IntPtr n_GetUrl(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWebResourceRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Url);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0000E498 File Offset: 0x0000C698
		public Android.Net.Uri Url
		{
			get
			{
				if (this.id_getUrl == IntPtr.Zero)
				{
					this.id_getUrl = JNIEnv.GetMethodID(this.class_ref, "getUrl", "()Landroid/net/Uri;");
				}
				return Java.Lang.Object.GetObject<Android.Net.Uri>(JNIEnv.CallObjectMethod(base.Handle, this.id_getUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400018F RID: 399
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebResourceRequest", typeof(IWebResourceRequestInvoker));

		// Token: 0x04000190 RID: 400
		private IntPtr class_ref;

		// Token: 0x04000191 RID: 401
		private static Delegate cb_hasGesture;

		// Token: 0x04000192 RID: 402
		private IntPtr id_hasGesture;

		// Token: 0x04000193 RID: 403
		private static Delegate cb_isForMainFrame;

		// Token: 0x04000194 RID: 404
		private IntPtr id_isForMainFrame;

		// Token: 0x04000195 RID: 405
		private static Delegate cb_isRedirect;

		// Token: 0x04000196 RID: 406
		private IntPtr id_isRedirect;

		// Token: 0x04000197 RID: 407
		private static Delegate cb_getMethod;

		// Token: 0x04000198 RID: 408
		private IntPtr id_getMethod;

		// Token: 0x04000199 RID: 409
		private static Delegate cb_getRequestHeaders;

		// Token: 0x0400019A RID: 410
		private IntPtr id_getRequestHeaders;

		// Token: 0x0400019B RID: 411
		private static Delegate cb_getUrl;

		// Token: 0x0400019C RID: 412
		private IntPtr id_getUrl;
	}
}
