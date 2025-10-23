using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Security.Cert;

namespace Javax.Net.Ssl
{
	// Token: 0x02000091 RID: 145
	[Register("javax/net/ssl/X509TrustManager", DoNotGenerateAcw = true)]
	internal class IX509TrustManagerInvoker : Java.Lang.Object, IX509TrustManager, ITrustManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002348 File Offset: 0x00000548
		private static IntPtr java_class_ref
		{
			get
			{
				return IX509TrustManagerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000236C File Offset: 0x0000056C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IX509TrustManagerInvoker._members;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002373 File Offset: 0x00000573
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000237B File Offset: 0x0000057B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IX509TrustManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002387 File Offset: 0x00000587
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IX509TrustManagerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.net.ssl.X509TrustManager'.");
			}
			return handle;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000023B2 File Offset: 0x000005B2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000023E4 File Offset: 0x000005E4
		public IX509TrustManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IX509TrustManagerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000241C File Offset: 0x0000061C
		private static Delegate GetCheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler()
		{
			if (IX509TrustManagerInvoker.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
			{
				IX509TrustManagerInvoker.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IX509TrustManagerInvoker.n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_));
			}
			return IX509TrustManagerInvoker.cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002440 File Offset: 0x00000640
		private static void n_CheckClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_chain, IntPtr native_authType)
		{
			IX509TrustManager @object = Java.Lang.Object.GetObject<IX509TrustManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			X509Certificate[] array = (X509Certificate[])JNIEnv.GetArray(native_chain, JniHandleOwnership.DoNotTransfer, typeof(X509Certificate));
			string @string = JNIEnv.GetString(native_authType, JniHandleOwnership.DoNotTransfer);
			@object.CheckClientTrusted(array, @string);
			if (array != null)
			{
				JNIEnv.CopyArray<X509Certificate>(array, native_chain);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002488 File Offset: 0x00000688
		public unsafe void CheckClientTrusted(X509Certificate[] chain, string authType)
		{
			if (this.id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray<X509Certificate>(chain);
			IntPtr intPtr2 = JNIEnv.NewString(authType);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, ptr);
			if (chain != null)
			{
				JNIEnv.CopyArray<X509Certificate>(intPtr, chain);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002523 File Offset: 0x00000723
		private static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Handler()
		{
			if (IX509TrustManagerInvoker.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == null)
			{
				IX509TrustManagerInvoker.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IX509TrustManagerInvoker.n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_));
			}
			return IX509TrustManagerInvoker.cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002548 File Offset: 0x00000748
		private static void n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_chain, IntPtr native_authType)
		{
			IX509TrustManager @object = Java.Lang.Object.GetObject<IX509TrustManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			X509Certificate[] array = (X509Certificate[])JNIEnv.GetArray(native_chain, JniHandleOwnership.DoNotTransfer, typeof(X509Certificate));
			string @string = JNIEnv.GetString(native_authType, JniHandleOwnership.DoNotTransfer);
			@object.CheckServerTrusted(array, @string);
			if (array != null)
			{
				JNIEnv.CopyArray<X509Certificate>(array, native_chain);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002590 File Offset: 0x00000790
		public unsafe void CheckServerTrusted(X509Certificate[] chain, string authType)
		{
			if (this.id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewArray<X509Certificate>(chain);
			IntPtr intPtr2 = JNIEnv.NewString(authType);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_, ptr);
			if (chain != null)
			{
				JNIEnv.CopyArray<X509Certificate>(intPtr, chain);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000262B File Offset: 0x0000082B
		private static Delegate GetGetAcceptedIssuersHandler()
		{
			if (IX509TrustManagerInvoker.cb_getAcceptedIssuers == null)
			{
				IX509TrustManagerInvoker.cb_getAcceptedIssuers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IX509TrustManagerInvoker.n_GetAcceptedIssuers));
			}
			return IX509TrustManagerInvoker.cb_getAcceptedIssuers;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000264F File Offset: 0x0000084F
		private static IntPtr n_GetAcceptedIssuers(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<X509Certificate>(Java.Lang.Object.GetObject<IX509TrustManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAcceptedIssuers());
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002664 File Offset: 0x00000864
		public X509Certificate[] GetAcceptedIssuers()
		{
			if (this.id_getAcceptedIssuers == IntPtr.Zero)
			{
				this.id_getAcceptedIssuers = JNIEnv.GetMethodID(this.class_ref, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
			}
			return (X509Certificate[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getAcceptedIssuers), JniHandleOwnership.TransferLocalRef, typeof(X509Certificate));
		}

		// Token: 0x04000009 RID: 9
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/net/ssl/X509TrustManager", typeof(IX509TrustManagerInvoker));

		// Token: 0x0400000A RID: 10
		private IntPtr class_ref;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;

		// Token: 0x0400000C RID: 12
		private IntPtr id_checkClientTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;

		// Token: 0x0400000E RID: 14
		private IntPtr id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_getAcceptedIssuers;

		// Token: 0x04000010 RID: 16
		private IntPtr id_getAcceptedIssuers;
	}
}
